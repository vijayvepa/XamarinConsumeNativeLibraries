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

2. In `File -> Project Settings`, change `Derived Data` location to `Project-relative`. This will put the `.a` file in the current project folder. 

	NOTE: Make sure that `DerivedData` folder is in `.gitignore` file (Not checked into source control).

3. Build the project, you will get the following error:

```
invalid iOS deployment version '-mios-simulator-version-min=11.1', iOS 10 is the maximum deployment target for 32-bit targets
```

4. In the `Build Settings` change the deployment target to `ios 10.0` to fix the error.

5. Near the `run` button, click on `BMCheckBox`, select `edit schemes` for Run, and choose `Release` option.

6. `Run` the project for `iPhone 8` simulator (or any other simulator), and run it for `Generic Device`. It will create two files in `DerivedData`.

	- .../BEMCheckbox/DerivedData/BEMCheckbox/Build/Products/Release-iphonesimulator/libBEMCheckBox.a
	- .../BEMCheckbox/DerivedData/BEMCheckbox/Build/Products/Release-iphonesimulator/libBEMCheckBox.a

	We need to combine these files.

7. Combine the above files using these command.

	```bash
	cd /BEMCheckbox/DerivedData/BEMCheckbox/Build/Products

	lipo -create Release-iphoneos/libBEMCheckbox.a Release-iphonesimulator/libBEMCheckBox.a -output libBEMCheckBox.a

	```
8. Verify that the resulting file has all the supported architectures

	```bash
	lipo -info libBEMCheckBox.a

	Architectures in the fat file: libBEMCheckBox.a are: armv7 armv7s i386 x86_64 arm64
	```

### Option 2: Using Makefile

- Create a file with name `Makefile` (no file extension) in the root of the project.  
	See the `/BEMCheckbox/Makefile` for reference.

- Update xcodeproj name as needed.
- Run the `make` command on the folder to generate the library file.

#### Troubleshooting

##### Error: makefile:9: *** missing separator. Stop

*Reference*:
https://stackoverflow.com/questions/16931770/makefile4-missing-separator-stop

**Cause**:  
Makefile needs to include tabs. Most editors replace tabs with spaces, this needs to be disabled when saving Makefile

**Solution**  
Depends on the editor. On Visual Studio Code, I setup these settings:
```
    "editor.insertSpaces": false,
    "editor.detectIndentation": false
``` 

##### Error: Objective-C Error iOS 10 is the maximum deployment target for 32-bit targets 

**Cause**  
This occurs because when creating a new project, it defaults to deployment target of iOS 11.2. 

**Solution**  
On XCode, select the `xcodeproj` file in the project explorer, go to `Build Settings`, change Deployment target to `iOS 10.0` or lower.

Alternatively, we can remove the 32 bit part from the Makefile
















