#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var VERSION = "8.0.0";
var NUGET_SUFIX = ".2";
var GESTURES_VERSION = "0.4.2";
var ACCOUNTS_VERSION = "0.1.0";
var OFFLINE_VERSION = "0.6.0";
var OFFLINE_NUGET_SUFIX=".0";
var ACCOUNTS_NUGET_SUFIX="";
var GESTURES_NUGET_SUFIX="";
var ANNOTATION_VERSION="0.7.0";
var ANNOTATION_NUGET_SUFIX=".0";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var artifacts = new [] {
    // new Artifact {
    //     Version =GESTURES_VERSION,
    //     NativeVersion = GESTURES_VERSION,
    //     ReleaseNotes = new string [] 
    //     {
    //         "Mapbox for Android Gestures - v{0}"
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = "./Naxam.MapboxGestures.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapboxgestures.nuspec",
    //     DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-gestures/{0}/mapbox-android-gestures-{0}.aar",
    //     JarPath = "./Naxam.MapboxGestures.Droid/Jars/mapbox-android-gestures.aar"
    //  },
    // new Artifact {
    //     Version =ACCOUNTS_VERSION,
    //     NativeVersion = ACCOUNTS_VERSION,
    //     ReleaseNotes = new string [] 
    //     {
    //         "Mapbox for Android Accounts - v{0}"
    //     },
    //     SolutionPath = "./mapbox-android.sln",
    //     AssemblyInfoPath = ".Naxam.MapboxAccounts.Droid/Properties/AssemblyInfo.cs",
    //     NuspecPath = "./mapboxaccounts.nuspec",
    //     DownloadUrl = "http://jcenter.bintray.com/com/mapbox/mapboxsdk/mapbox-android-accounts/{0}/mapbox-android-accounts-{0}.aar",
    //     JarPath = "./Naxam.MapboxAccounts.Droid/Jars/mapbox-android-accounts.aar"
    //  },
    new Artifact {
        Version = VERSION + NUGET_SUFIX,
        NativeVersion = VERSION,
        ReleaseNotes = new string [] {
            string.Format("Mapbox for Android - v{0}", VERSION)
        },
        SolutionPath = "./mapbox-android.sln",
        AssemblyInfoPath = "./Naxam.Mapbox.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapbox.nuspec",
        DownloadUrl = "http://central.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-sdk/{0}/mapbox-android-sdk-{0}.aar",
        JarPath = "./Naxam.Mapbox.Droid/Jars/mapbox-android-sdk.aar",
        Dependencies = new NuSpecDependency[] {
                new NuSpecDependency {
                Id = "Naxam.MapboxAccounts.Droid",
                Version = ACCOUNTS_VERSION
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxGestures.Droid",
                Version = GESTURES_VERSION
            },
            new NuSpecDependency {
                Id = "Naxam.Mapbox.Services.Android.Telemetry",
                Version = "4.4.1"
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxSdkGeojson.Droid",
                Version = "4.8.0.1"
            },
            new NuSpecDependency {
                Id = "Naxam.MapboxSdkTurf.Droid",
                Version = "4.8.0"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Fragment",
                Version = "28.0.0.1"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Annotations",
                Version = "28.0.0.1"
            },
            new NuSpecDependency {
                Id = "Xbindings.ReLinker.Droid",
                Version = "1.2.3"
            },
        },
    },
    new Artifact {
        Version = OFFLINE_VERSION + OFFLINE_NUGET_SUFIX,
        NativeVersion = OFFLINE_VERSION,
        ReleaseNotes = new string [] {
            string.Format("Mapbox for Android - Offline Plugin v{0}", OFFLINE_VERSION)
        },
        SolutionPath = "./mapbox-android.sln",
        AssemblyInfoPath = "./Naxam.MapboxOffline.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapbox-android-plugin-offline-v8.nuspec",
        DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-offline-v8/{0}/mapbox-android-plugin-offline-v8-{0}.aar",
        JarPath = "./Naxam.MapboxOffline.Droid/Jars/mapbox-android-plugin-offline-v8.aar",
        Dependencies = new NuSpecDependency[] {
                new NuSpecDependency {
                Id = "Naxam.Mapbox.Droid",
                Version = VERSION + NUGET_SUFIX
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.v7.AppCompat",
                Version = "28.0.0.1"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.v4",
                Version = "28.0.0.1"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Design",
                Version = "28.0.0.1"
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.Constraint.Layout",
                Version = "1.1.2"
            },
            new NuSpecDependency {
                Id = "Naxam.Jakewharton.Timber",
                Version = "4.7.1"
            },
        }
    },
    new Artifact {
        Version = ANNOTATION_VERSION + ANNOTATION_NUGET_SUFIX,
        NativeVersion = ANNOTATION_VERSION,
        ReleaseNotes = new string [] {
            string.Format("Mapbox for Android - Annotation Plugin v{0}", ANNOTATION_VERSION)
        },
        SolutionPath = "./mapbox-android.sln",
        AssemblyInfoPath = "./Naxam.MapboxAnnotation.Droid/Properties/AssemblyInfo.cs",
        NuspecPath = "./mapbox-android-plugin-annotation-v8.nuspec",
        DownloadUrl = "https://repo1.maven.org/maven2/com/mapbox/mapboxsdk/mapbox-android-plugin-annotation-v8/{0}/mapbox-android-plugin-annotation-v8-{0}.aar",
        JarPath = "./Naxam.MapboxAnnotation.Droid/Jars/mapbox-android-plugin-annotation-v8.aar",
        Dependencies = new NuSpecDependency[] {
                new NuSpecDependency {
                Id = "Naxam.Mapbox.Droid",
                Version = VERSION + NUGET_SUFIX
            },
            new NuSpecDependency {
                Id = "Xamarin.Android.Support.v7.AppCompat",
                Version = "28.0.0.1"
            },
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

Task("Build")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetRestore(artifact.SolutionPath);
        MSBuild(artifact.SolutionPath, settings => {
            settings.ToolVersion = MSBuildToolVersion.VS2019;
            settings.SetConfiguration(configuration);
        });
    }
});

Task("Pack")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
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
    // .IsDependentOn("Downloads")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Build")
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