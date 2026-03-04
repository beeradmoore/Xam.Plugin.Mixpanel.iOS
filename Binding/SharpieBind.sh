#!/bin/sh

#./FetchFramework.sh

sharpie bind \
    -namespace Xam.Plugin.Mixpanel.iOS \
    -sdk iphoneos26.2 \
    -framework ./Xam.Plugin.Mixpanel.iOS/Mixpanel.xcframework/ios-arm64/Mixpanel.framework \
    --output NewBinding
