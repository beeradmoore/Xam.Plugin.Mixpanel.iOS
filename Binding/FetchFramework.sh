#!/bin/sh

carthage update
cp -r Carthage/Build/iOS/Mixpanel.framework .
rm -rf Carthage

