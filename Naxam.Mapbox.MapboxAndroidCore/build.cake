#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "0.2.1";
var PATCH = "";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var slnPath = "./Naxam.Mapbox.MapboxAndroidCore.sln";
var artifacts = new [] {
    new Artifact {
        Name = "",
        Version = VERSION,
        AssemblyInfoPath = "./Naxam.Mapbox.MapboxAndroidCore/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapboxandroidcore.nuspec",
        DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-core/{0}/mapbox-android-core-{0}.aar",
        JarPath = "./Naxam.Mapbox.MapboxAndroidCore/Jars/mapbox-android-core.aar"
    },
};

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Downloads")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        var downloadUrl = string.Format(artifact.DownloadUrl, artifact.Version);
        var jarPath = string.Format(artifact.JarPath, artifact.Version);

        DownloadFile(downloadUrl, jarPath);
    }
});

Task("Clean")
    .Does(() =>
{
    CleanDirectory("./packages");

    var nugetPackages = GetFiles("./*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }
});

Task("Restore-NuGet-Packages")
    .Does(() =>
{
    NuGetRestore(slnPath);
});

Task("Build")
    .Does(() =>
{
    MSBuild(slnPath, settings => settings.SetConfiguration(configuration));
});

Task("UpdateVersion")
    .Does(() => 
{
    foreach(var artifact in artifacts) {
        ReplaceRegexInFiles(artifact.AssemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", artifact.Version + PATCH));
    }
});

Task("Pack")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetPack(artifact.NuspecPath, new NuGetPackSettings {
            Version = artifact.Version + PATCH,
            Title = $"MapboxAndroidCore for Android",
            Description = $"Xamarin.Android binding library - MapboxAndroidCore",
            Summary = $"Xamarin.Android binding library - MapboxAndroidCore",
            // Dependencies = artifact.Dependencies,
            ReleaseNotes = new [] {
                $"MapboxAndroidCore for Android - v{artifact.Version}"
            }
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Downloads")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore-NuGet-Packages")
    .IsDependentOn("Build")
    .IsDependentOn("Pack");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

class Artifact {
    public string AssemblyInfoPath { get; set; }

    public string SolutionPath { get; set; }

    public string DownloadUrl  { get; set; }

    public string JarPath { get; set; }

    public string NuspecPath { get; set; }

    public string Version { get; set; }

    public string ReleaseNote { get; set; }

    public string Name { get; set; }

    public NuSpecDependency[] Dependencies { get; set; } = new NuSpecDependency[0];
}