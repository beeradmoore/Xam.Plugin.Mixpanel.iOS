#!/bin/sh
./FetchFramework.sh

if [ $? -ne 0 ]
then
   echo "ERROR: Unable to fetch Mixpanel framework"
   exit 1
fi

msbuild Xam.Plugin.Mixpanel.iOS.csproj -property:Configuration=Release -target:Clean,Build
nuget pack Xam.Plugin.Mixpanel.iOS.nuspec -Symbols -SymbolPackageFormat snupkg