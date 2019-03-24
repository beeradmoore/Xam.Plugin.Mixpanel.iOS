#!/bin/sh

./FetchFramework.sh

sharpie bind -namespace Xam.Plugin.Mixpanel.iOS -prefix NewBinding_ -sdk iphoneos -framework ./Mixpanel.framework