# Bindings Library

- Create a iOS bindings project in Visual Studio
- Add the fat library generated in the NativeLibrary folder to the project
- Copy some of the code generated by `sharpie` in `StructsAndEnums` to `Structs.cs` 
	- Add classes prefixed by BEM from the end of the generated file
	- Enums cannot inherit from `nint` so change it to `long`  
- Copy some code generated by `sharpie` in `ApiDefinitions.cs`
	- Add classes prefixed by BEM from the end of the generated file
	- Remove `NSHashtable` properties as we really don't need to map those.