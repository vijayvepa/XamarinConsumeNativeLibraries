#Info Color Picker
This is the example native component provided in 
https://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/walkthrough/

## Troubleshooting

### Error: makefile:4: *** missing separator. Stop

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

### Error: Objective-C Error iOS 10 is the maximum deployment target for 32-bit targets 

**Cause**  
This occurs because when creating a new project, it defaults to deployment target of iOS 11.2. 

**Solution**  
On XCode, select the `xcodeproj` file in the project explorer, go to `Build Settings`, change Deployment target to `iOS 10.0` or lower.

Alternatively, we can remove the 32 bit part from the Makefile



