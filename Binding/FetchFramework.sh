#!/bin/sh

set -euo pipefail

rm -rf Mixpanel.xcframework

# Currently only building for iOS. tvOS, macOS and watchOS are not supported with this nuget.
carthage update --use-xcframeworks --platform ios

cp -r Carthage/Build/Mixpanel.xcframework .
rm -rf Carthage