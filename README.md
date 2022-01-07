# Xam.Plugin.Mixpanel.iOS

Xamarin.iOS bindings for Mixpanel iOS v3.6.2.


## Installation

Xam.Plugin.Mixpanel.iOS is available via NuGet.
[https://www.nuget.org/packages/Xam.Plugin.Mixpanel.iOS/](https://www.nuget.org/packages/Xam.Plugin.Mixpanel.iOS/)

[![NuGet](https://img.shields.io/nuget/vpre/Xam.Plugin.Mixpanel.iOS.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Plugin.Mixpanel.iOS)

## Usage

Include Mixpanel
``` c#
using Xam.Plugin.Mixpanel.iOS;
```

And then follow the docs provided at the Mixpanel Developer Documentation (https://developer.mixpanel.com/docs/ios)

## Build

### Visutal Studio for Mac
1. Run FetchFramework.sh 
    ``` sh
    $ ./FetchFramework.sh
    ```
2. Open Xam.Plugin.Mixpanel.iOS.sln
3. Build and fetch your .dlls from the bin/ directory.

### Building a .nupkg
1. Run BuildNugetPackage.sh
    ``` sh
    $ ./BuildNugetPackage.sh
    ```
2. Fetch your Xam.Plugin.Mixpanel.iOS.x.y.z.nupkg and Xam.Plugin.Mixpanel.iOS.x.y.z.snupkg from the Binding directory.

## Updating Mixpanel SDK
To update the Mixpanel SDK change the version within Binding/Cartfile to your desired SDK version and run the FetchFramework.sh script.

If there are API changes you will want to run SharpieBind.sh instead and examine code output in the newly generated NewBinding_ApiDefinition.cs and NewBinding_StructsAndEnums.cs files. Desired API changes should be then modified in the ApiDefinition.cs and StructsAndEnums.cs files. 
*NOTE: The NewBinding_ files are not build ready and need to be modified manually.*

## Requirements
- [Xcode 13.0](https://developer.apple.com/download/more/)
- [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
- [Carthage](https://github.com/Carthage/Carthage)
- [Objective Sharpie](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started)


## TODO
* Verify the Verify statements work as expected.
* Figure out how to handle MixpanelTypeCategory correctly.

Pull requests welcome!
