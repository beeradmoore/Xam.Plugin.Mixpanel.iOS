#!/bin/sh

set -e

#./FetchFramework.sh


rm -rf Xam.Plugin.Mixpanel.iOS/bin
rm -rf Xam.Plugin.Mixpanel.iOS/obj

dotnet pack \
    --configuration Release \
    --include-source \
    --include-symbols \
    "Xam.Plugin.Mixpanel.iOS/Xam.Plugin.Mixpanel.iOS.csproj"
