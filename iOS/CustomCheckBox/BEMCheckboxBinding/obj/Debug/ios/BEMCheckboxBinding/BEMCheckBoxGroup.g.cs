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
	[Register("BEMCheckBoxGroup", true)]
	public unsafe partial class BEMCheckBoxGroup : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BEMCheckBoxGroup");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BEMCheckBoxGroup () : base (NSObjectFlag.Empty)
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
		protected BEMCheckBoxGroup (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BEMCheckBoxGroup (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addCheckBoxToGroup:")]
		[CompilerGenerated]
		public virtual void AddCheckBoxToGroup (BEMCheckBox checkBox)
		{
			if (checkBox == null)
				throw new ArgumentNullException ("checkBox");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCheckBoxToGroup:"), checkBox.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCheckBoxToGroup:"), checkBox.Handle);
			}
		}
		
		[Export ("groupWithCheckBoxes:")]
		[CompilerGenerated]
		public static BEMCheckBoxGroup GroupWithCheckBoxes (BEMCheckBox[] checkBoxes)
		{
			var nsa_checkBoxes = checkBoxes == null ? null : NSArray.FromNSObjects (checkBoxes);
			
			BEMCheckBoxGroup ret;
			ret =  Runtime.GetNSObject<BEMCheckBoxGroup> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("groupWithCheckBoxes:"), nsa_checkBoxes == null ? IntPtr.Zero : nsa_checkBoxes.Handle));
			if (nsa_checkBoxes != null)
				nsa_checkBoxes.Dispose ();
			
			return ret;
		}
		
		[Export ("removeCheckBoxFromGroup:")]
		[CompilerGenerated]
		public virtual void RemoveCheckBoxFromGroup (BEMCheckBox checkBox)
		{
			if (checkBox == null)
				throw new ArgumentNullException ("checkBox");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeCheckBoxFromGroup:"), checkBox.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeCheckBoxFromGroup:"), checkBox.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool MustHaveSelection {
			[Export ("mustHaveSelection")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("mustHaveSelection"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mustHaveSelection"));
				}
			}
			
			[Export ("setMustHaveSelection:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMustHaveSelection:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMustHaveSelection:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual BEMCheckBox SelectedCheckBox {
			[Export ("selectedCheckBox", ArgumentSemantic.Retain)]
			get {
				BEMCheckBox ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<BEMCheckBox> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedCheckBox")));
				} else {
					ret =  Runtime.GetNSObject<BEMCheckBox> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedCheckBox")));
				}
				return ret;
			}
			
			[Export ("setSelectedCheckBox:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedCheckBox:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedCheckBox:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class BEMCheckBoxGroup */
}
