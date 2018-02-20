# Copy Framework file from Release-iphoneos
cp -r Release-iphoneos/SampleSwiftFramework.framework SampleSwiftFramework.framework
# Combine Release-iphoneSimulator with Release iphoneos
lipo -create Release-iphonesimulator/SampleSwiftFramework.framework/SampleSwiftFramework  Release-iphoneos/SampleSwiftFramework.framework/SampleSwiftFramework -output SampleSwiftFramework.framework/SampleSwiftFramework 
# Combine the swift modules
cp  Release-iphonesimulator/SampleSwiftFramework.framework/Modules/SampleSwiftFramework.swiftmodule/*.* SampleSwiftFramework.framework/Modules/SampleSwiftFramework.swiftmodule/