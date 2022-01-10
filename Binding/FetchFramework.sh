#!/bin/sh

carthage update --use-xcframeworks --platform ios

# If carthage failed.
if [ $? -ne 0 ]
then
   exit 1
fi

cp -r Carthage/Build/Mixpanel.xcframework .

# If we couldn't copy the Mixpanel.xcframework.
if [ $? -ne 0 ]
then
   exit 1
fi

rm -rf Carthage

