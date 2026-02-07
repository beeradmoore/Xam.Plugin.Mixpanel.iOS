#!/bin/sh

#./FetchFramework.sh

sharpie bind \
    -namespace Xam.Plugin.Mixpanel.iOS \
    -prefix NewBinding_ \
    -sdk iphoneos18.2 \
    -framework ./Mixpanel.xcframework/ios-arm64/Mixpanel.framework


    #harpie bind \
    #--sdk=iphonesimulator18.2 \
    #--output=SharpieOutput_ios-arm64_x86_64-simulator \
    #--framework=Carthage/Build/Mixpanel.xcframework/ios-arm64_x86_64-simulator/Mixpanel.framework
