
# Binding Swift Library to Xamarin

This project exercises the blog at https://medium.com/@Flash3001/binding-swift-libraries-xamarin-ios-ff32adbc7c76

## Native Swift Library

### Swift Project

- In XCode, select new project-> choose `Cocoa Touch Framework`, language as `swift`.

- Add the swift code, make sure at least the calling code inherits from `NSObject`.

- In `Project Explorer`, select the `xcode project`, choose `Build Settings` and search for `bitcode`. Set `Enable BitCode` to `No`.

- Change build setting to `Release` and build for Device and Simulator

### Fat Library

- In the `Project Explorer`, select `Products`->`NAME.framework`, right click -> Reveal in Finder.
- See the `Output` folder in this Repo for additional details.



