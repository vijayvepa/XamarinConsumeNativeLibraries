
# 1. Binding Swift Library to Xamarin

<!-- TOC -->

- [1. Binding Swift Library to Xamarin](#1-binding-swift-library-to-xamarin)
	- [1.1. Native Swift Library](#11-native-swift-library)
		- [1.1.1. Swift Project](#111-swift-project)
		- [1.1.2. Fat Library](#112-fat-library)
	- [1.2. Binding Project](#12-binding-project)
	- [1.3. BLOCKED: Swift 4.0 Not Working](#13-blocked-swift-40-not-working)

<!-- /TOC -->

This project exercises the blog at https://medium.com/@Flash3001/binding-swift-libraries-xamarin-ios-ff32adbc7c76

## 1.1. Native Swift Library

### 1.1.1. Swift Project

- In XCode, select new project-> choose `Cocoa Touch Framework`, language as `swift`.

- Add the swift code, make sure at least the calling code inherits from `NSObject`.

- In `Project Explorer`, select the `xcode project`, choose `Build Settings` and search for `bitcode`. Set `Enable BitCode` to `No`.

- In `Build Settings` make sure swift version is `Swift 3.x`  
  **NOTE**: Swift 4.0 is not generating all functions in the header file.
  **Solution Found**: Annotate each function with `@objc`.

- Change build setting to `Release` and build for Device and Simulator

### 1.1.2. Fat Library

- In the `Project Explorer`, select `Products`->`NAME.framework`, right click -> Reveal in Finder.
- See the `Output` folder in this repository for additional details.


## 1.2. Binding Project

- In Visual Studio, create a new iOS binding project
- Copy the framework file generated in Fat Library section to this project folder.
- In `Native References`, add the copied framework file.


## 1.3. BLOCKED: Swift 4.0 Not Working

- The app is crashing without any logs. Cannot continue the investigation.
- Verified that Swift3.0 compiler generated framework file is working fine, 

- but (as of 2018-02-22), the default XCode swift compiler is  Swift 4.0. Even if we change the target language level to Swift 3.2, it is being compiled by Swift 4.0 compiler. 

