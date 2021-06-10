# Xamarin.Android binding libraries for Mapbox Android SDK

Naxam creates and maintains Xamarin.Android bindings for Mapbox Android SDK, including:

 - Android SDK
 - Core
 - Google-Payment
 - PayPal OneTouch
 - PayPal DataCollector
 - Browser Switch
 - DropIn UI

## Building

The build script for this project uses [Cake](http://cakebuild.net).  To run the build, you can use one of the bootstrapper files either for Mac or Windows (experimental support only):

The bootstrapper script will automatically download Cake.exe and all the required tools and files into the `./tools/` folder.

Required dotnet core tools:

* binderator

Optional dotnet core tools:

* cake

To update all tools: 
```
	dotnet tool uninstall 	-g Cake.Tool
	dotnet tool install     -g Cake.Tool	
	dotnet tool uninstall   -g Xamarin.AndroidBinderator.Tool
	dotnet tool install     -g Xamarin.AndroidBinderator.Tool
```

The following targets can be specified:

 - `ci` builds the kitchen sink - what we run in CI
 - `libs` builds the class library bindings (depends on `binderate`)
 - `binderate` downloads the external dependencies and generates folder structure
 - `samples` builds all of the samples (depends on `libs`)
 - `nuget` builds the nuget packages (depends on `libs`)
 - `clean` cleans up everything

***NOTE***: The `binderate` build task may take awhile to run as it downloads several large dependencies.

You may want to consider passing `--verbosity diagnostic` (or `-Verbosity diagnostic` on Windows) to the bootstrapper to enable more verbose output, including downloading progress.

```
dotnet cake
```

### Working in Visual Studio / Visual Studio for Mac

Before the `.sln` files will compile in Visual Studio or Visual Studio for Mac, the external dependencies need to be downloaded.
This can be done by running the `dotnet cake`.  
After the externals are setup, the `.sln` files should compile in an IDE.
