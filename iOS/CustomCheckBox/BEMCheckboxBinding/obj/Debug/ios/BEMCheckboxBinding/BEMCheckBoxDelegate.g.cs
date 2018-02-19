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
	[Protocol (Name = "BEMCheckBoxDelegate", WrapperType = typeof (BEMCheckBoxDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTapCheckBox", Selector = "didTapCheckBox:", ParameterType = new Type [] { typeof (BEMCheckboxBinding.BEMCheckBox) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnimationDidStopForCheckBox", Selector = "animationDidStopForCheckBox:", ParameterType = new Type [] { typeof (BEMCheckboxBinding.BEMCheckBox) }, ParameterByRef = new bool [] { false })]
	public interface IBEMCheckBoxDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class BEMCheckBoxDelegate_Extensions {
		[CompilerGenerated]
		public static void DidTapCheckBox (this IBEMCheckBoxDelegate This, BEMCheckBox checkBox)
		{
			if (checkBox == null)
				throw new ArgumentNullException ("checkBox");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didTapCheckBox:"), checkBox.Handle);
		}
		
		[CompilerGenerated]
		public static void AnimationDidStopForCheckBox (this IBEMCheckBoxDelegate This, BEMCheckBox checkBox)
		{
			if (checkBox == null)
				throw new ArgumentNullException ("checkBox");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("animationDidStopForCheckBox:"), checkBox.Handle);
		}
		
	}
	
	internal sealed class BEMCheckBoxDelegateWrapper : BaseWrapper, IBEMCheckBoxDelegate {
		[Preserve (Conditional = true)]
		public BEMCheckBoxDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace BEMCheckboxBinding {
	[Protocol]
	[Register("BEMCheckBoxDelegate", false)]
	[Model]
	public unsafe partial class BEMCheckBoxDelegate : NSObject, IBEMCheckBoxDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BEMCheckBoxDelegate () : base (NSObjectFlag.Empty)
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
		protected BEMCheckBoxDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BEMCheckBoxDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("animationDidStopForCheckBox:")]
		[CompilerGenerated]
		public virtual void AnimationDidStopForCheckBox (BEMCheckBox checkBox)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didTapCheckBox:")]
		[CompilerGenerated]
		public virtual void DidTapCheckBox (BEMCheckBox checkBox)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class BEMCheckBoxDelegate */
}
