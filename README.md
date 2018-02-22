# Xamarin Consume Native Libraries
Proof-of-concept for consuming native libraries in Xamarin 

This project demonstrates consumption of components built in Objective-C and Android into Xamarin.

<!-- TOC -->

- [Xamarin Consume Native Libraries](#xamarin-consume-native-libraries)
    - [1.1. iOS](#11-ios)
        - [1.1.1. Process](#111-process)
        - [1.1.2. Tutorials](#112-tutorials)
    - [1.2. Android](#12-android)
        - [Color Picker Example](#color-picker-example)
        - [Consume Android Library Example](#consume-android-library-example)
        - [Tutorials](#tutorials)

<!-- /TOC -->


## 1.1. iOS

### 1.1.1. Process 

There are three steps for consuming native iOS bindings in Xamarin

 1. Create a static library that can be used for *all* architectures that iOS needs to support.  
	
	 As of this writing, these are `armv7`, `armv7s`, `i-386`. For example, `i-386` will be used when running the library in the *iOS Simulator*, whereas `armv7` will be used on the actual *iPhone* device.

	Each architecture will have its own output in `library-i386.a` file or `library-armv7.a` file (as an example). These need to be combined into a single file ("fat library") `library-combined.a` file. 
	
	Xamarin will use this file with a *compile-time linking*.

2. In order to invoke the library from C# code, we need to write two csharp files `ApiDefinitions.cs` and `StructsAndEnums.cs`. 

	Xamarin provides a tool called [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/) to use as a *reference* for creating these files. 

	We need to determine the current `xcode sdk level` using the command:

	```bash
	> sharpie xcode -sdks
	
	sdk: appletvos11.2    arch: arm64   
	sdk: iphoneos11.2     arch: arm64   armv7   
	sdk: macosx10.13      arch: x86_64  i386    
	sdk: watchos4.2       arch: armv7k  

	```
	Next, we can generate the binding files from the *header* files in the original native library, as below:

	```bash
	>sharpie bind -output=CustomCheckBox -namespace=CustomCheckBoxFinal /PATH/TO/HEADER/FILES/*.h -sdk=iphoneos11.2
	```
	Notice the `-sdk` parameter needs to match the installed sdk.

	This will generate two reference files but (as of this writing), the files are over 50,000 lines in length and full of compiler errors.
	
	*NOTE*: We can only use what we need from the files, we don't need to get the whole file compiled. The code is generated as a reference anyway, and typically we don't need a lot of code to call the underlying library.

3. Create a `Xamarin binding` project in Visual Studio, 
	
	- Add the `library-combined.a` file generated in step 1 to the project.  
	- Copy *minimal code* from `ApiDefinitions.cs` and `StructsAndEnums.cs` files generated in step 2.
	
	Compile the binding library. This can now be called from a `Xamarin.iOS` project (and possibly from `Xamarin.Forms` project using *custom renderer* concept.)


### 1.1.2. Tutorials
- [Walk-through on the Official Xamarin Website](https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/walkthrough/)  
	This is the official documentation for binding iOS Objective-C libraries to Xamarin
	

- [Video Walk-through: Working with ObjC Binding](https://www.youtube.com/watch?v=Pd2KsrqtHf8)  
	An example video that shows alternative way for certain steps of the process

- [Binding Swift Library](https://medium.com/@Flash3001/binding-swift-libraries-xamarin-ios-ff32adbc7c76)   
	Explains the additional steps for binding swift libraries.


**NOTE:** See subfolders for more detail.

## 1.2. Android

### Color Picker Example

Walkthrough: https://www.youtube.com/watch?v=TWkuk1Mgf8g


1. This example consumes the library at https://github.com/QuadFlask/colorpicker 
2. Download the `.aar` file from the repository.
3. Create a `Xamarin Android Binding` project in Visual Studio
4. Copy the `.aar` file into the Jars folder, change `build action` to  `LibraryProjectZip`
5. Create a `Xamarin Android App` project and add a reference to `Xamarin Binding` project created above.
6. Copy the *Usage as a widget* markup in the above github location into `Main.axml`

```xml
	<com.flask.colorpicker.ColorPickerView
		android:id="@+id/color_picker_view"
		android:layout_width="match_parent"
		android:layout_height="wrap_content"
		app:alphaSlider="true"
		app:density="12"
		app:lightnessSlider="true"
		app:wheelType="FLOWER"
		app:lightnessSliderView="@+id/v_lightness_slider"
	    app:alphaSliderView="@+id/v_alpha_slider"
		/>

	<com.flask.colorpicker.slider.LightnessSlider
		android:id="@+id/v_lightness_slider"
		android:layout_width="match_parent"
		android:layout_height="48dp"
		/>

	<com.flask.colorpicker.slider.AlphaSlider
		android:id="@+id/v_alpha_slider"
		android:layout_width="match_parent"
		android:layout_height="48dp"
		/>
```

7. We need to define `xml namespace` for the `app` tag prefix as below:

```xml
	xmlns:app="http://schemas.android.com/apk/res-auto"
```

**NOTE:** This is the post-script resolved namespace from the apk.
See https://stackoverflow.com/questions/10448006/xml-namespace-declaration-auto-substitute-package-name


### Consume Android Library Example

This consumes an in-house example of android aar file but invokes the control from code.

1. Create a `Xamarin Android Binding` project in Visual Studio
2. Copy the `.aar` file into the Jars folder, change `build action` to  `InputJar`
3. Create a `Xamarin Android App` project and add a reference to `Xamarin Binding` project created above.
4. Consume the generated binding library in `MainActivity.cs` as below:

```csharp
	protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            DrawBarChart chart = new DrawBarChart(this.ApplicationContext);
            SetContentView(chart.RootView);


            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
        }
    }
```

### Tutorials

- [Binding an AAR (Not in English)](https://www.youtube.com/watch?v=TWkuk1Mgf8g)
	This is exercised in the ColorPickerLibrary
- [Android Aresenal](https://android-arsenal.com/)
	Android Libraries repository