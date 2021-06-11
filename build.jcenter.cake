// Tools needed by cake addins
#tool nuget:?package=vswhere&version=2.7.1
#tool nuget:?package=nuget.commandline&version=5.3.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=3.2.1
#addin nuget:?package=Newtonsoft.Json&version=11.0.2

using System;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var TARGET = Argument ("t", Argument ("target", "ci"));
var MAX_CPU_COUNT = Argument("maxcpucount", 0);

// Lists all the artifacts and their versions for com.android.support.*
// https://dl.google.com/dl/android/maven2/com/android/support/group-index.xml
// Master list of all the packages in the repo:
// https://dl.google.com/dl/android/maven2/master-index.xml

// Resolve Xamarin.Android installation
var XAMARIN_ANDROID_PATH = EnvironmentVariable ("XAMARIN_ANDROID_PATH");
var ANDROID_SDK_BASE_VERSION = "v1.0";
var ANDROID_SDK_VERSION = "v10.0";
string AndroidSdkBuildTools = $"29.0.2";

if (string.IsNullOrEmpty(XAMARIN_ANDROID_PATH)) {
	if (IsRunningOnWindows()) {
		var vsInstallPath = VSWhereLatest(new VSWhereLatestSettings { Requires = "Component.Xamarin", IncludePrerelease = true });
		XAMARIN_ANDROID_PATH = vsInstallPath.Combine("Common7/IDE/ReferenceAssemblies/Microsoft/Framework/MonoAndroid").FullPath;
	} else {
		if (DirectoryExists("/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xamarin.android/xbuild-frameworks/MonoAndroid"))
			XAMARIN_ANDROID_PATH = "/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xamarin.android/xbuild-frameworks/MonoAndroid";
		else
			XAMARIN_ANDROID_PATH = "/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/xbuild-frameworks/MonoAndroid";
	}
}
if (!DirectoryExists($"{XAMARIN_ANDROID_PATH}/{ANDROID_SDK_VERSION}"))
	throw new Exception($"Unable to find Xamarin.Android {ANDROID_SDK_VERSION} at {XAMARIN_ANDROID_PATH}.");

// Load all the git variables
var BUILD_COMMIT = EnvironmentVariable("BUILD_COMMIT") ?? "DEV";
var BUILD_NUMBER = EnvironmentVariable("BUILD_NUMBER") ?? "DEBUG";
var BUILD_TIMESTAMP = DateTime.UtcNow.ToString();

var REQUIRED_DOTNET_TOOLS = new [] {
	"xamarin-android-binderator",
	"xamarin.androidx.migration.tool"
};


string[] Configs = new []
{
	"Debug",
	"Release"
};

var MONODROID_PATH = "/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/mandroid/platforms/" + ANDROID_SDK_VERSION + "/";
if (IsRunningOnWindows ()) 
{
	var vsInstallPath = VSWhereLatest (new VSWhereLatestSettings { Requires = "Component.Xamarin", IncludePrerelease = true });
	MONODROID_PATH = vsInstallPath.Combine ("Common7/IDE/ReferenceAssemblies/Microsoft/Framework/MonoAndroid/" + ANDROID_SDK_VERSION).FullPath;
}

var MSCORLIB_PATH = "/Library/Frameworks/Xamarin.Android.framework/Libraries/mono/2.1/";
if (IsRunningOnWindows ()) {

	var DOTNETDIR = new DirectoryPath (Environment.GetFolderPath (Environment.SpecialFolder.Windows)).Combine ("Microsoft.NET/");

	if (DirectoryExists (DOTNETDIR.Combine ("Framework64")))
		MSCORLIB_PATH = MakeAbsolute (DOTNETDIR.Combine("Framework64/v4.0.30319/")).FullPath;
	else
		MSCORLIB_PATH = MakeAbsolute (DOTNETDIR.Combine("Framework/v4.0.30319/")).FullPath;
}


string JAVA_HOME = EnvironmentVariable ("JAVA_HOME") ?? Argument ("java_home", "");
string ANDROID_HOME = EnvironmentVariable ("ANDROID_HOME") ?? Argument ("android_home", "");
string ANDROID_SDK_ROOT = EnvironmentVariable ("ANDROID_SDK_ROOT") ?? Argument ("android_sdk_root", "");

// Log some variables
Information ($"JAVA_HOME            : {JAVA_HOME}");
Information ($"ANDROID_HOME         : {ANDROID_HOME}");
Information ($"ANDROID_SDK_ROOT     : {ANDROID_SDK_ROOT}");
Information ($"MONODROID_PATH       : {MONODROID_PATH}");
Information ($"MSCORLIB_PATH        : {MSCORLIB_PATH}");
Information ($"XAMARIN_ANDROID_PATH : {XAMARIN_ANDROID_PATH}");
Information ($"ANDROID_SDK_VERSION  : {ANDROID_SDK_VERSION}");
Information ($"BUILD_COMMIT:        : {BUILD_COMMIT}");
Information ($"BUILD_NUMBER:        : {BUILD_NUMBER}");
Information ($"BUILD_TIMESTAMP:     : {BUILD_TIMESTAMP}");

// You shouldn't have to configure anything below here
// ######################################################

void RunProcess(FilePath fileName, string processArguments)
{
	var exitCode = StartProcess(fileName, processArguments);
	if (exitCode != 0)
		throw new Exception ($"Process {fileName} exited with code {exitCode}.");
}

Task("tools-update")
    .Does
    (
        () =>
        {
            /*
            dotnet tool uninstall   -g Cake.Tool
            dotnet tool install     -g Cake.Tool
            dotnet tool uninstall   -g xamarin.androidbinderator.tool
            dotnet tool install     -g xamarin.androidbinderator.tool
            dotnet tool uninstall   -g xamarin.androidx.migration.tool
            dotnet tool install     -g xamarin.androidx.migration.tool

            StartProcess("dotnet", "tool uninstall   -g Cake.Tool");
            StartProcess("dotnet", "tool install     -g Cake.Tool");
            */
            StartProcess("dotnet", "tool uninstall   -g xamarin.androidbinderator.tool");
            StartProcess("dotnet", "tool install     -g xamarin.androidbinderator.tool");
            StartProcess("dotnet", "tool uninstall   -g xamarin.androidx.migration.tool");
            StartProcess("dotnet", "tool install     -g xamarin.androidx.migration.tool");
        }
    );

Task("binderate")
	.Does(() =>
{
	var configJcenterFile = MakeAbsolute(new FilePath("./config.jcenter.json")).FullPath;
	var basePath = MakeAbsolute(new DirectoryPath ("./")).FullPath;

	Information($"- {configJcenterFile}");
	
	RunProcess("xamarin-android-binderator",
		$"--config=\"{configJcenterFile}\" --basepath=\"{basePath}\"");
	Information($"EnsureDirectoryExists");

	// needed for offline builds 28.0.0.1 to 28.0.0.3
	EnsureDirectoryExists("./externals/nuget-local-feed/");

	FilePathCollection files = GetFiles("./samples/**/*.csproj");
	foreach(FilePath file in files)
	{
		Information($"File: {file}");

		XmlDocument xml = new XmlDocument();
		xml.Load($"{file}");
        XmlNamespaceManager mgr = new XmlNamespaceManager(xml.NameTable);
        mgr.AddNamespace("x", xml.DocumentElement.NamespaceURI);
	    // XmlNodeList list = xml.SelectNodes("/packages/package/");
	    XmlNodeList list = xml.SelectNodes("//x:PackageReference[@Include]", mgr);	
		Information($"{list.Count}");	
		foreach (XmlNode xn in list)
		{
			string id = xn.Attributes["Include"].Value;  	// .Attributes["id"].Value; // attribute id packages.config
			//string text = xn["Text"].InnerText; 			// Text Node
			string v = xn.Attributes["Version"]?.Value; 	// attribute version 

			Information($"		id	   : {id}");

			if ( v is null)
			{
				v = xn.InnerText; //SelectSingleNode("Version", mgr).Value;
			}
			Information($"		version: {v}");

			if ( id.Contains("Braintree") || id.Contains("PayPal") )
			{
				Information($"		skipping download of {id}");
				continue;
			}

			string url = $"https://www.nuget.org/api/v2/package/{id}/{v}";
			string file1 = $"./externals/nuget-local-feed/{id.ToLower()}.{v}.nupkg";
			try
			{
				if ( ! FileExists(file1) )
				{
					Information($"		download of {id}");
					DownloadFile(url, file1);
				}
			}
			catch (System.Exception exc)
			{
				Error($"Unable to download: {url}");
				Error($"             error: {exc.Message}");
			}
		}
	}
});

string nuget_version_template = "3.11.0";
string nuget_version_suffix = "";
JArray binderator_json_array = null;
string slnFilePath = "./generated/mapbox-android-jcenter.sln";


Task("mergetargets")
	.Does(() =>
{
	/*****************************
	* BEGIN: Merge all the .targets together into one for the sake of compiling samples
	******************************/
	var generatedTargets = GetFiles("./generated/*/Xamarin.*.targets");

	// Load the doc to append to, and the doc to append
	var xFileRoot = System.Xml.Linq.XDocument.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<Project ToolsVersion=\"4.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\n</Project>");
	System.Xml.Linq.XNamespace nsRoot = xFileRoot.Root.Name.Namespace;

	foreach (var generatedTarget in generatedTargets) {
		var xFileChild = System.Xml.Linq.XDocument.Load (MakeAbsolute (generatedTarget).FullPath);
		System.Xml.Linq.XNamespace nsChild = xFileRoot.Root.Name.Namespace;

		// Add all the elements under <Project> into the existing file's <Project> node
		foreach (var xItemToAdd in xFileChild.Element (nsChild + "Project").Elements ())
			xFileRoot.Element (nsRoot + "Project").Add (xItemToAdd);
	}

	// Inject a property to prevent errors from missing assemblies in .targets
	// this allows us to use one big .targets file in all the projects and not have to figure out which specific
	// ones each project needs to reference for development purposes
	if (!xFileRoot.Descendants (nsRoot + "XamarinBuildResourceMergeThrowOnMissingAssembly").Any ()) {
		xFileRoot.Element (nsRoot + "Project")
			.AddFirst (new System.Xml.Linq.XElement (nsRoot + "PropertyGroup",
				new System.Xml.Linq.XElement (nsRoot + "XamarinBuildResourceMergeThrowOnMissingAssembly", false)));
	}

	xFileRoot.Save ("./generated/generated.targets");
	/*****************************
	* END: Merge all the .targets together into one for the sake of compiling samples
	******************************/
});


Task("libs")
	.IsDependentOn("nuget-restore")
	.Does(() =>
{
	NuGetRestore(slnFilePath, new NuGetRestoreSettings { });

	Configs = new string[] { "Release" };

	foreach(string config in Configs)
	{
		MSBuild(slnFilePath, c => {
			c.Configuration = config;
			c.MaxCpuCount = MAX_CPU_COUNT;
			c.BinaryLogger = new MSBuildBinaryLogSettings { Enabled = true, FileName = MakeAbsolute(new FilePath("./output/libs.binlog")).FullPath };
			c.Properties.Add("DesignTimeBuild", new [] { "false" });
			c.Properties.Add("AndroidSdkBuildToolsVersion", new [] { AndroidSdkBuildTools });
			if (! string.IsNullOrEmpty(ANDROID_HOME))
			{
				c.Properties.Add("AndroidSdkDirectory", new [] { $"{ANDROID_HOME}" } );
			}
		});
	}
});

Task("samples-directory-build-targets")
	.Does
	(
		() =>
		{
			Information("samples Director.Build.targets from config.jcenter.json ...");
			using (StreamReader reader = System.IO.File.OpenText(@"./config.jcenter.json"))
			{
				JsonTextReader jtr = new JsonTextReader(reader);
				binderator_json_array = (JArray)JToken.ReadFrom(jtr);
			}

			foreach(JObject jo in binderator_json_array[0]["artifacts"])
			{
				string version       = (string) jo["version"];
				string nuget_version = (string) jo["nugetVersion"];
				Information($"groupId       = {jo["groupId"]}");
				Information($"artifactId    = {jo["artifactId"]}");
				Information($"version       = {version}");
				Information($"nuget_version = {nuget_version}");
				Information($"nugetId       = {jo["nugetId"]}");
			}

	        XmlDocument doc = new XmlDocument();
	        XmlElement element_p = doc.CreateElement( string.Empty, "Project", string.Empty );
        	doc.AppendChild( element_p );
	       	XmlElement element_ig = doc.CreateElement( string.Empty, "ItemGroup", string.Empty );
        	element_p.AppendChild(element_ig);

			foreach(JObject jo in binderator_json_array[0]["artifacts"])
			{
				string version       = (string) jo["version"];
				string nuget_version = (string) jo["nugetVersion"];
				Information($"groupId       = {jo["groupId"]}");
				Information($"artifactId    = {jo["artifactId"]}");
				Information($"version       = {version}");
				Information($"nuget_version = {nuget_version}");
				Information($"nugetId       = {jo["nugetId"]}");

				XmlElement element_pr = doc.CreateElement( string.Empty, "PackageReference", string.Empty );
	        	element_ig.AppendChild(element_pr);
				XmlAttribute attr_update = doc.CreateAttribute("Update");
				attr_update.Value = (string) jo["nugetId"];
				element_pr.Attributes.Append(attr_update);
				XmlAttribute attr_version = doc.CreateAttribute("Version");
				attr_version.Value = nuget_version;
				element_pr.Attributes.Append(attr_version);
			}

			doc.Save( System.IO.Path.Combine("samples", "Directory.Build.targets" ));

			return;
		}
	);

Task("samples")
	.IsDependentOn("libs")
	.IsDependentOn("samples-directory-build-targets")
	.IsDependentOn("mergetargets")
	.IsDependentOn("allbindingprojectrefs")
	.Does(() =>
{
	Configs = new string[] { "Debug", "Release" };

	DeleteDirectories(GetDirectories("./samples/**/bin/"), new DeleteDirectorySettings() { Force = true, Recursive = true });
	DeleteDirectories(GetDirectories("./samples/**/obj/"), new DeleteDirectorySettings() { Force = true, Recursive = true });

	
	var sampleSlns = GetFiles("./samples/**/*.sln");

	foreach(string config in Configs)
	{
		foreach (var sampleSln in sampleSlns) 
		{
			string filename_sln = sampleSln.GetFilenameWithoutExtension().ToString();

			if ( ! filename_sln.Contains("BuildAll") )
			{
				NuGetRestore(sampleSln, new NuGetRestoreSettings { }); // R8 errors
			}
			Information($"Solution: {filename_sln}");
			MSBuild(sampleSln, c => {
				c.Configuration = config;
				c.Properties.Add("DesignTimeBuild", new [] { "false" });
				c.BinaryLogger = new MSBuildBinaryLogSettings
				{
					Enabled = true,
					FileName = MakeAbsolute(new FilePath($"./output/{filename_sln}.sample.binlog")).FullPath
				};
				if (! string.IsNullOrEmpty(ANDROID_HOME))
				{
					c.Properties.Add("AndroidSdkDirectory", new [] { $"{ANDROID_HOME}" } );
				}
			});
		}
	}

});

Task("allbindingprojectrefs")
	.Does(() =>
{
	Action<string,string> generateTargets = (string pattern, string file) => {
		var xmlns = (XNamespace)"http://schemas.microsoft.com/developer/msbuild/2003";
		var itemGroup = new XElement(xmlns + "ItemGroup");
		foreach (var nupkg in GetFiles(pattern)) {
			var filename = nupkg.GetFilenameWithoutExtension();
		var match = Regex.Match(filename.ToString(), @"(.+?)\.(\d+[\.0-9\-a-zA-Z]+)");
		itemGroup.Add(new XElement(xmlns + "PackageReference",
			new XAttribute("Include", match.Groups[1]),
			new XAttribute("Version", match.Groups[2])));
		}
		var xdoc = new XDocument(new XElement(xmlns + "Project", itemGroup));
		xdoc.Save(file);

	};

	generateTargets("./output/Naxam.*.nupkg", "./output/MapboxPackages.jcenter.targets");
});

Task("nuget-restore")
	.Does(() =>
{
	NuGetRestore(slnFilePath, new NuGetRestoreSettings { });
});


Task("nuget")
	.IsDependentOn("libs")
	.Does(() =>
{
	var outputPath = new DirectoryPath("./output");

	MSBuild (slnFilePath, c => {
		c.Configuration = "Release";
		c.MaxCpuCount = MAX_CPU_COUNT;
		c.BinaryLogger = new MSBuildBinaryLogSettings { Enabled = true, FileName = MakeAbsolute(new FilePath("./output/nuget.binlog")).FullPath };
		c.Targets.Clear();
		c.Targets.Add("Pack");
		c.Properties.Add("PackageOutputPath", new [] { MakeAbsolute(outputPath).FullPath });
		c.Properties.Add("PackageRequireLicenseAcceptance", new [] { "true" });
		c.Properties.Add("DesignTimeBuild", new [] { "false" });
		c.Properties.Add("AndroidSdkBuildToolsVersion", new [] { $"{AndroidSdkBuildTools}" });
    });
});

Task ("merge")
	.IsDependentOn ("libs")
	.Does (() =>
{
	var allDlls = 
		GetFiles ($"./generated/*/bin/Release/monoandroid*/Naxam.*.dll");
	var mergeDlls = allDlls
		.GroupBy(d => new FileInfo(d.FullPath).Name)
		.Select(g => g.FirstOrDefault())
		.ToList();

	EnsureDirectoryExists("./output/");
	RunProcess("androidx-migrator",
		$"merge" +
		$"  --assembly " + string.Join(" --assembly ", mergeDlls) +
		$"  --output ./output/Mapbox.jcenter.Merged.dll" +
		$"  --search \"{XAMARIN_ANDROID_PATH}/{ANDROID_SDK_VERSION}\" " +
		$"  --search \"{XAMARIN_ANDROID_PATH}/{ANDROID_SDK_BASE_VERSION}\" " +
		$"  --inject-assemblyname");
});

Task ("ci-setup")
	.WithCriteria (!BuildSystem.IsLocalBuild)
	.Does (() =>
{
	var glob = "./source/AssemblyInfo.cs";

	ReplaceTextInFiles(glob, "{BUILD_COMMIT}", BUILD_COMMIT);
	ReplaceTextInFiles(glob, "{BUILD_NUMBER}", BUILD_NUMBER);
	ReplaceTextInFiles(glob, "{BUILD_TIMESTAMP}", BUILD_TIMESTAMP);
});

// Task ("genapi")
// 	.IsDependentOn ("libs")
// 	.Does (() =>
// {
// 	var GenApiToolPath = GetFiles ("./tools/**/GenAPI.exe").FirstOrDefault ();

// 	// For some reason GenAPI.exe can't handle absolute paths on mac/unix properly, so always make them relative
// 	// GenAPI.exe -libPath:$(MONOANDROID) -out:Some.generated.cs -w:TypeForwards ./relative/path/to/Assembly.dll
// 	var libDirPrefix = IsRunningOnWindows () ? "output/" : "";

// 	var libs = new FilePath [] {
// 		"./" + libDirPrefix + "Xamarin.Android.Support.Compat.dll",
// 		"./" + libDirPrefix + "Xamarin.Android.Support.Core.UI.dll",
// 		"./" + libDirPrefix + "Xamarin.Android.Support.Core.Utils.dll",
// 		"./" + libDirPrefix + "Xamarin.Android.Support.Fragment.dll",
// 		"./" + libDirPrefix + "Xamarin.Android.Support.Media.Compat.dll",
// 	};

// 	foreach (var lib in libs) {
// 		var genName = lib.GetFilename () + ".generated.cs";

// 		var libPath = IsRunningOnWindows () ? MakeAbsolute (lib).FullPath : lib.FullPath;
// 		var monoDroidPath = IsRunningOnWindows () ? "\"" + MONODROID_PATH + "\"" : MONODROID_PATH;

// 		Information ("GenAPI: {0}", lib.FullPath);

// 		StartProcess (GenApiToolPath, new ProcessSettings {
// 			Arguments = string.Format("-libPath:{0} -out:{1}{2} -w:TypeForwards {3}",
// 							monoDroidPath + "," + MSCORLIB_PATH,
// 							IsRunningOnWindows () ? "" : "./",
// 							genName,
// 							libPath),
// 			WorkingDirectory = "./output/",
// 		});
// 	}

// 	MSBuild ("./GooglePlayServices.TypeForwarders.sln", c => c.Configuration = BUILD_CONFIG);

// 	CopyFile ("./support-v4/source/bin/" + BUILD_CONFIG + "/Xamarin.Android.Support.v4.dll", "./output/Xamarin.Android.Support.v4.dll");
// });

// Task ("docs-api-diff")
//     .Does (async () =>
// {
// 	var nupkgFiles = GetFiles ("./**/output/*.nupkg"); //get all of the nugets in the output

// 	Information ("Found ({0}) Nuget's to Diff", nupkgFiles.Count ());

// 	foreach (var nupkgFile in nupkgFiles)  //loop through each nuget that is found
// 	{
// 		Information("Diffing: {0}", nupkgFile);
// 		await BuildApiDiff(nupkgFile);
// 	}
// });

Task ("clean")
	.Does (() =>
{
	if (DirectoryExists ("./externals"))
		DeleteDirectory ("./externals", new DeleteDirectorySettings { Recursive = true, Force = true });

	if (DirectoryExists ("./generated"))
		DeleteDirectory ("./generated", new DeleteDirectorySettings { Recursive = true, Force = true });

	CleanDirectories ("./**/packages");
	CleanDirectories("./**/bin");
	CleanDirectories("./**/obj");
});

Task ("ci")
	.IsDependentOn ("ci-setup")
	//.IsDependentOn ("check-tools")
	//.IsDependentOn ("inject-variables")
	.IsDependentOn ("binderate")
	.IsDependentOn ("nuget")
	// .IsDependentOn ("merge")
	.IsDependentOn ("samples");

RunTarget (TARGET);
