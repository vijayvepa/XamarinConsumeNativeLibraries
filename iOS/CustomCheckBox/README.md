# Custom Check Box Native Binding

This code example is an exercise from the Video Walkthrough at 

- [Video Walk-through: Working with ObjC Binding](https://www.youtube.com/watch?v=Pd2KsrqtHf8)  

We create a binding library for the BMCheckBox objective-C library located at 
https://github.com/Boris-Em/BEMCheckBox


## Create Static Library Project 
1. Clone the repository from BEMCheckBox

2. Create a new Static Library project in XCode.

3. Delete the files created in the project.

4. Add existing files (in options, select Copy Items if Needed), select all the files in `BEMCheckBox` repo, `Classes` folder. 


## Make a Binary 

### Option 1: Using the UI

Setup settings in the XCode UI as below:

1. In `Build Settings` tab of `xcodeproj` file, look for `Valid Architectures` setting, and add `i386` to the list. In `Architectures`list, choose `Other` and add `arm64, arm7, arm7s and i386`.

2. In `File -> Project Settings`, change `Derived Data` location to `Project-relative`. This will put the .a file in the current project folder.














