# run sharpie xcode -sdks |grep iphoneos and store the result in OUTPUT
OUTPUT=$(sharpie xcode -sdks|grep iphoneos)
# get a substring between character 5 and 14 of OUTPUT and store it in VERSION
VERSION=${OUTPUT:5:14}
echo "version: " $VERSION  
# use the VERSION from above in sharpie bind
sharpie bind -output=CSharpBinding -namespace=SampleSwiftLibrary SampleSwiftFramework.framework/Headers/SampleSwiftFramework-Swift.h -sdk=$VERSION