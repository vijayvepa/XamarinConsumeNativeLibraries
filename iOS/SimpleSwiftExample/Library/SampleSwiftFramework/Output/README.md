## Creating FAT Library

- Create the FAT library using:

- lipo -create Release-iphonesimulator/NAME.framework/NAME Release-iphoneos/NAME.framework/NAME -output NAME.framework/NAME

- Copy the files in Release-iphonesimulator/NAME.framework/Modules/NAME.swiftmodule to NAME.framework/Modules/NAME.swiftmodule (until now it only contained files from the iphoneos)


See `MakeFatFramework.sh` 