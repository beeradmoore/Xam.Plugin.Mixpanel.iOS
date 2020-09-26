#!/bin/sh
./FetchFramework.sh
msbuild Xam.Plugin.Mixpanel.iOS.csproj -property:Configuration=Release -target:Clean,Build
nuget pack Xam.Plugin.Mixpanel.iOS.nuspec -Symbols -SymbolPackageFormat snupkg