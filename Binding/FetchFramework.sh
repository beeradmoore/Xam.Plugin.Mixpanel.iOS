#!/bin/sh

carthage update

# If carthage failed.
if [ $? -ne 0 ]
then
   exit 1
fi

cp -r Carthage/Build/iOS/Mixpanel.framework .

# If we couldn't copy the Mixpanel.framework.
if [ $? -ne 0 ]
then
   exit 1
fi

rm -rf Carthage

