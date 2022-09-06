#!/bin/sh

set -euo pipefail

#./FetchFramework.sh

sharpie bind -namespace Xam.Plugin.Mixpanel.iOS -prefix NewBinding_ -sdk iphoneos -framework ./Mixpanel.xcframework/ios-arm64_armv7/Mixpanel.framework