#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "6.4.0";
var NUGET_SUFIX = "";
var GESTURES_VERSION = "0.2.0";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var artifacts = new [] {
    new Artifact {
        Version =GESTURES_VERSION,
        NativeVersion = GESTURES_VERSION,
        ReleaseNotes = new string [] 
        {
            "Mapbox for Android Gestures - v{0}"
        },
        SolutionPath = "./mapboxgestures-droid/Naxam.MapboxGestures.Droid.sln",
        AssemblyInfoPath = "./mapboxgestures-droid/Naxam.MapboxGestures.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapboxgestures-droid/mapboxgestures.nuspec",
        DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-gestures/{0}/mapbox-android-gestures-{0}.aar",
        JarPath = "./mapboxgestures-droid/Naxam.MapboxGestures.Droid/Jars/mapbox-android-gestures.aar"
     },
    new Artifact {
        Version = VERSION + NUGET_SUFIX,
        NativeVersion = VERSION,
        ReleaseNotes = new string [] {
            "Mapbox for Android - SdkCore v{0}"
        },
        SolutionPath = "./mapbox-android.sln",
        AssemblyInfoPath = "./Naxam.Mapbox.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapbox.nuspec",
        DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-sdk/{0}/mapbox-android-sdk-{0}.aar",
        JarPath = "./Naxam.Mapbox.Droid/Jars/mapbox-android-sdk.aar",
        Dependencies = new NuSpecDependency[] {
                 new NuSpecDependency {
                    Id = "Xamarin.Android.Support.Annotations",
                    Version = "27.0.2.1"
                },
                new NuSpecDependency {
                    Id = "Xamarin.Android.Support.Fragment",
                    Version = "27.0.2.1"
                },
                new NuSpecDependency {
                    Id = "Naxam.Jakewharton.Timber",
                    Version = "4.7.1"
                },
                new NuSpecDependency {
                    Id = "Naxam.MapboxSdkGeojson.Droid",
                    Version = "3.4.0"
                },
                new NuSpecDependency {
                    Id = "Naxam.Mapbox.Services.Android.Telemetry",
                    Version = "3.1.5.2"
                },
                new NuSpecDependency {
                    Id = "Square.OkHttp3",
                    Version = "3.8.1"
                },
                 new NuSpecDependency {
                    Id = "Naxam.MapboxGestures.Droid",
                    Version = "0.2.0"
                }
        }
    }
};

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Downloads")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        var downloadUrl = string.Format(artifact.DownloadUrl, artifact.NativeVersion);
        var jarPath = string.Format(artifact.JarPath, artifact.NativeVersion);

        DownloadFile(downloadUrl, jarPath);
    }
});

Task("Clean")
    .Does(() =>
{
    CleanDirectory("**/*/packages");

    CleanDirectory("./nugets/*");

    var nugetPackages = GetFiles("./nugets/*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }
});

Task("UpdateVersion")
    .Does(() => 
{
    foreach(var artifact in artifacts) {
        ReplaceRegexInFiles(artifact.AssemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", artifact.Version));
    }
});

Task("Pack")
    .IsDependentOn("Downloads")
    .IsDependentOn("UpdateVersion")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetRestore(artifact.SolutionPath);
        MSBuild(artifact.SolutionPath, settings => settings.SetConfiguration(configuration));
        NuGetPack(artifact.NuspecPath, new NuGetPackSettings {
            Version = artifact.Version,
            Dependencies = artifact.Dependencies,
            ReleaseNotes = artifact.ReleaseNotes,
            OutputDirectory = "./nugets"
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Pack");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

class Artifact {
    public string Version { get; set; }
    public string NativeVersion { get; set; }

    public string AssemblyInfoPath { get; set; }

    public string SolutionPath { get; set; }

    public string DownloadUrl  { get; set; }

    public string JarPath { get; set; }

    public string NuspecPath { get; set; }

    public string[] ReleaseNotes { get; set; }

    public NuSpecDependency[] Dependencies { get; set; }
}