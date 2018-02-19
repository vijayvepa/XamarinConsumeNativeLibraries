using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreAnimation;

namespace BEMCheckboxBinding
{
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //

    // @interface BEMAnimationManager : NSObject
    [BaseType(typeof(NSObject))]
    interface BEMAnimationManager
    {
        // @property (nonatomic) CGFloat animationDuration;
        [Export("animationDuration")]
        nfloat AnimationDuration { get; set; }

        // -(instancetype)initWithAnimationDuration:(CGFloat)animationDuration;
        [Export("initWithAnimationDuration:")]
        IntPtr Constructor(nfloat animationDuration);

        // -(CABasicAnimation *)strokeAnimationReverse:(BOOL)reverse;
        [Export("strokeAnimationReverse:")]
        CABasicAnimation StrokeAnimationReverse(bool reverse);

        // -(CABasicAnimation *)opacityAnimationReverse:(BOOL)reverse;
        [Export("opacityAnimationReverse:")]
        CABasicAnimation OpacityAnimationReverse(bool reverse);

        // -(CABasicAnimation *)morphAnimationFromPath:(UIBezierPath *)fromPath toPath:(UIBezierPath *)toPath;
        [Export("morphAnimationFromPath:toPath:")]
        CABasicAnimation MorphAnimationFromPath(UIBezierPath fromPath, UIBezierPath toPath);

        // -(CAKeyframeAnimation *)fillAnimationWithBounces:(NSUInteger)bounces amplitude:(CGFloat)amplitude reverse:(BOOL)reverse;
        [Export("fillAnimationWithBounces:amplitude:reverse:")]
        CAKeyFrameAnimation FillAnimationWithBounces(nuint bounces, nfloat amplitude, bool reverse);
    }

    interface CAKeyframeAnimation
    {
        
        // @property (copy) NSArray<NSNumber *> * _Nullable keyTimes;
        [NullAllowed, Export("keyTimes", ArgumentSemantic.Copy)]
        NSNumber[] KeyTimes { get; set; }


        // @property (copy) NSString * _Nonnull calculationMode;
        [Export("calculationMode")]
        string CalculationMode { get; set; }

        // @property (copy) NSArray<NSNumber *> * _Nullable tensionValues;
        [NullAllowed, Export("tensionValues", ArgumentSemantic.Copy)]
        NSNumber[] TensionValues { get; set; }

        // @property (copy) NSArray<NSNumber *> * _Nullable continuityValues;
        [NullAllowed, Export("continuityValues", ArgumentSemantic.Copy)]
        NSNumber[] ContinuityValues { get; set; }

        // @property (copy) NSArray<NSNumber *> * _Nullable biasValues;
        [NullAllowed, Export("biasValues", ArgumentSemantic.Copy)]
        NSNumber[] BiasValues { get; set; }

        // @property (copy) NSString * _Nullable rotationMode;
        [NullAllowed, Export("rotationMode")]
        string RotationMode { get; set; }
    }

    // @interface CABasicAnimation : CAPropertyAnimation
    [BaseType(typeof(NSObject))]
    interface CABasicAnimation
    {
        // @property (strong) id _Nullable fromValue;
        [NullAllowed, Export("fromValue", ArgumentSemantic.Strong)]
        NSObject FromValue { get; set; }

        // @property (strong) id _Nullable toValue;
        [NullAllowed, Export("toValue", ArgumentSemantic.Strong)]
        NSObject ToValue { get; set; }

        // @property (strong) id _Nullable byValue;
        [NullAllowed, Export("byValue", ArgumentSemantic.Strong)]
        NSObject ByValue { get; set; }
    }

    // @interface BEMCheckBoxGroup : NSObject
    [BaseType(typeof(NSObject))]
    interface BEMCheckBoxGroup
    {
        
        // @property (nonatomic, strong) BEMCheckBox * _Nullable selectedCheckBox;
        [NullAllowed, Export("selectedCheckBox", ArgumentSemantic.Strong)]
        BEMCheckBox SelectedCheckBox { get; set; }

        // @property (nonatomic) BOOL mustHaveSelection;
        [Export("mustHaveSelection")]
        bool MustHaveSelection { get; set; }

        // +(instancetype _Nonnull)groupWithCheckBoxes:(NSArray<BEMCheckBox *> * _Nullable)checkBoxes;
        [Static]
        [Export("groupWithCheckBoxes:")]
        BEMCheckBoxGroup GroupWithCheckBoxes([NullAllowed] BEMCheckBox[] checkBoxes);

        // -(void)addCheckBoxToGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("addCheckBoxToGroup:")]
        void AddCheckBoxToGroup(BEMCheckBox checkBox);

        // -(void)removeCheckBoxFromGroup:(BEMCheckBox * _Nonnull)checkBox;
        [Export("removeCheckBoxFromGroup:")]
        void RemoveCheckBoxFromGroup(BEMCheckBox checkBox);
    }

    // @interface BEMCheckBox : UIControl <CAAnimationDelegate>
    [BaseType(typeof(UIControl))]
    interface BEMCheckBox 
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        BEMCheckBoxDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<BEMCheckBoxDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL on;
        [Export("on")]
        bool On { get; set; }

        // @property (nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) CGFloat animationDuration;
        [Export("animationDuration")]
        nfloat AnimationDuration { get; set; }

        // @property (nonatomic) BOOL hideBox;
        [Export("hideBox")]
        bool HideBox { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onTintColor;
        [Export("onTintColor", ArgumentSemantic.Strong)]
        UIColor OnTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onFillColor;
        [Export("onFillColor", ArgumentSemantic.Strong)]
        UIColor OnFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull offFillColor;
        [Export("offFillColor", ArgumentSemantic.Strong)]
        UIColor OffFillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull onCheckColor;
        [Export("onCheckColor", ArgumentSemantic.Strong)]
        UIColor OnCheckColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (readonly, nonatomic, strong) BEMCheckBoxGroup * _Nullable group;
        [NullAllowed, Export("group", ArgumentSemantic.Strong)]
        BEMCheckBoxGroup Group { get; }

        // @property (nonatomic) BEMBoxType boxType;
        [Export("boxType", ArgumentSemantic.Assign)]
        BEMBoxType BoxType { get; set; }

        // @property (nonatomic) BEMAnimationType onAnimationType;
        [Export("onAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OnAnimationType { get; set; }

        // @property (nonatomic) BEMAnimationType offAnimationType;
        [Export("offAnimationType", ArgumentSemantic.Assign)]
        BEMAnimationType OffAnimationType { get; set; }

        // @property (assign, nonatomic) CGSize minimumTouchSize;
        [Export("minimumTouchSize", ArgumentSemantic.Assign)]
        CGSize MinimumTouchSize { get; set; }

        // -(void)setOn:(BOOL)on animated:(BOOL)animated;
        [Export("setOn:animated:")]
        void SetOn(bool on, bool animated);

        // -(void)reload;
        [Export("reload")]
        void Reload();
    }

    // @protocol BEMCheckBoxDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface BEMCheckBoxDelegate
    {
        // @optional -(void)didTapCheckBox:(BEMCheckBox * _Nonnull)checkBox;
        [Export("didTapCheckBox:")]
        void DidTapCheckBox(BEMCheckBox checkBox);

        // @optional -(void)animationDidStopForCheckBox:(BEMCheckBox * _Nonnull)checkBox;
        [Export("animationDidStopForCheckBox:")]
        void AnimationDidStopForCheckBox(BEMCheckBox checkBox);
    }

    // @interface BEMPathManager : NSObject
    [BaseType(typeof(NSObject))]
    interface BEMPathManager
    {
        // @property (nonatomic) CGFloat size;
        [Export("size")]
        nfloat Size { get; set; }

        // @property (nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) BEMBoxType boxType;
        [Export("boxType", ArgumentSemantic.Assign)]
        BEMBoxType BoxType { get; set; }

        // -(UIBezierPath *)pathForBox;
        [Export("pathForBox")]
        UIBezierPath PathForBox { get; }

        // -(UIBezierPath *)pathForCheckMark;
        [Export("pathForCheckMark")]
        UIBezierPath PathForCheckMark { get; }

        // -(UIBezierPath *)pathForLongCheckMark;
        [Export("pathForLongCheckMark")]
        UIBezierPath PathForLongCheckMark { get; }

        // -(UIBezierPath *)pathForFlatCheckMark;
        [Export("pathForFlatCheckMark")]
        UIBezierPath PathForFlatCheckMark { get; }
    }
}
