//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace BEMCheckboxBinding {
	[Register("BEMAnimationManager", true)]
	public unsafe partial class BEMAnimationManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BEMAnimationManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BEMAnimationManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BEMAnimationManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BEMAnimationManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAnimationDuration:")]
		[CompilerGenerated]
		public BEMAnimationManager (nfloat animationDuration)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("initWithAnimationDuration:"), animationDuration), "initWithAnimationDuration:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("initWithAnimationDuration:"), animationDuration), "initWithAnimationDuration:");
			}
		}
		
		[Export ("fillAnimationWithBounces:amplitude:reverse:")]
		[CompilerGenerated]
		public virtual global::CoreAnimation.CAKeyFrameAnimation FillAnimationWithBounces (nuint bounces, nfloat amplitude, bool reverse)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::CoreAnimation.CAKeyFrameAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nfloat_bool (this.Handle, Selector.GetHandle ("fillAnimationWithBounces:amplitude:reverse:"), bounces, amplitude, reverse));
			} else {
				return  Runtime.GetNSObject<global::CoreAnimation.CAKeyFrameAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint_nfloat_bool (this.SuperHandle, Selector.GetHandle ("fillAnimationWithBounces:amplitude:reverse:"), bounces, amplitude, reverse));
			}
		}
		
		[Export ("morphAnimationFromPath:toPath:")]
		[CompilerGenerated]
		public virtual CABasicAnimation MorphAnimationFromPath (global::UIKit.UIBezierPath fromPath, global::UIKit.UIBezierPath toPath)
		{
			if (fromPath == null)
				throw new ArgumentNullException ("fromPath");
			if (toPath == null)
				throw new ArgumentNullException ("toPath");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("morphAnimationFromPath:toPath:"), fromPath.Handle, toPath.Handle));
			} else {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("morphAnimationFromPath:toPath:"), fromPath.Handle, toPath.Handle));
			}
		}
		
		[Export ("opacityAnimationReverse:")]
		[CompilerGenerated]
		public virtual CABasicAnimation OpacityAnimationReverse (bool reverse)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("opacityAnimationReverse:"), reverse));
			} else {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("opacityAnimationReverse:"), reverse));
			}
		}
		
		[Export ("strokeAnimationReverse:")]
		[CompilerGenerated]
		public virtual CABasicAnimation StrokeAnimationReverse (bool reverse)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("strokeAnimationReverse:"), reverse));
			} else {
				return  Runtime.GetNSObject<CABasicAnimation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("strokeAnimationReverse:"), reverse));
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat AnimationDuration {
			[Export ("animationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("animationDuration"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("animationDuration"));
				}
			}
			
			[Export ("setAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAnimationDuration:"), value);
				}
			}
		}
		
	} /* class BEMAnimationManager */
}
