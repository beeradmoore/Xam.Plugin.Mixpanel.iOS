#!/bin/sh

set -e

carthage update --use-xcframeworks

cp -r Carthage/Build/Mixpanel.xcframework Xam.Plugin.Mixpanel.iOS/

#rm -rf Carthage
