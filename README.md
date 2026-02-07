# Xam.Plugin.Mixpanel.iOS

Xamarin.iOS bindings for Mixpanel iOS v5.0.9.

This repository aims to target `net9.0-ios` and `net10.0-ios` which are currently the latest .NET iOS STS and LTS releases. 

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

These build instructions are intended to be run on macOS.

### Local dll builds
1. Navigate to the `Binding` directory
2. Run `FetchFramework.sh`
3. Run `BuildDlls.sh`
4. Fetch your `Xam.Plugin.Mixpanel.iOS.dll` from the `Xam.Plugin.Mixpanel.iOS/bin/Release/net10-ios/` directory.

### Building a .nupkg
1. Navigate to the `Binding` directory
2. Run `FetchFramework.sh`
3. Run `BuildNugetPackage.sh`
2. Fetch your `Xam.Plugin.Mixpanel.iOS.x.y.z.nupkg` and `Xam.Plugin.Mixpanel.iOS.x.y.z.snupkg` from the `Xam.Plugin.Mixpanel.iOS/bin/Release/`` directory.

## Updating Mixpanel SDK
To update the Mixpanel SDK change the version within `Binding/Cartfile `to your desired SDK version and run the `FetchFramework.sh` script. This desired version is generally then latest version from [mixpanel/mixpanel-iphone releases](https://github.com/mixpanel/mixpanel-iphone/releases).

If there are API changes you will want to also run `SharpieBind.sh` and examine code output in the newly generated `NewBinding_ApiDefinition.cs` and `NewBinding_StructsAndEnums.cs` files. Desired API changes should be then modified in the `ApiDefinition.cs` and `StructsAndEnums.cs` files. 
*NOTE: The `NewBinding_` files are not build ready and need to be modified manually.*

## Requirements
- [Xcode 26.2](https://developer.apple.com/download/more/)
- [Carthage](https://github.com/Carthage/Carthage)
- [Objective Sharpie](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started)


## TODO
* Verify the `Verify` statements work as expected.
* Figure out how to handle `MixpanelTypeCategory` correctly.

Pull requests welcome!
