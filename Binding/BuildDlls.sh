#!/bin/sh

set -e

#./FetchFramework.sh


rm -rf Xam.Plugin.Mixpanel.iOS/bin
rm -rf Xam.Plugin.Mixpanel.iOS/obj

dotnet build \
    --configuration Release \
    "Xam.Plugin.Mixpanel.iOS/Xam.Plugin.Mixpanel.iOS.csproj"
