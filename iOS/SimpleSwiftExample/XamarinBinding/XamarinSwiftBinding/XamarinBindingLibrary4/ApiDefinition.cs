using Foundation;

namespace XamarinBindingLibrary4
{

    // @interface SampleClass : NSObject
    [BaseType(typeof(NSObject))]
    interface SampleClass
    {
        // -(NSString * _Nonnull)getValue __attribute__((warn_unused_result));
        [Export("getValue")]

        string Value { get; }
    }
}
