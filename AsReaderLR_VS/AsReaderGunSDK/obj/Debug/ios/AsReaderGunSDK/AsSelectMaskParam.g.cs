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

namespace AsReaderGunSDK {
	[Register("AsSelectMaskParam", true)]
	public unsafe partial class AsSelectMaskParam : NSObject, INSCoding {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsSelectMaskParam");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsSelectMaskParam () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public AsSelectMaskParam (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AsSelectMaskParam (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsSelectMaskParam (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithIndex:")]
		[CompilerGenerated]
		public AsSelectMaskParam (int index)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("initWithIndex:"), index), "initWithIndex:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("initWithIndex:"), index), "initWithIndex:");
			}
		}
		
		[Export ("initWithParameterIndex:target:action:bank:offset:mask:used:")]
		[CompilerGenerated]
		public AsSelectMaskParam (int index, MaskTargetType maskTarget, MaskActionType maskAction, MemoryBank maskBank, int maskOffset, string maskData, bool usedMask)
			: base (NSObjectFlag.Empty)
		{
			if (maskData == null)
				throw new ArgumentNullException ("maskData");
			var nsmaskData = NSString.CreateNative (maskData);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_UInt32_UInt32_int_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithParameterIndex:target:action:bank:offset:mask:used:"), index, (UInt32)maskTarget, (UInt32)maskAction, (UInt32)maskBank, maskOffset, nsmaskData, usedMask), "initWithParameterIndex:target:action:bank:offset:mask:used:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_UInt32_UInt32_UInt32_int_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithParameterIndex:target:action:bank:offset:mask:used:"), index, (UInt32)maskTarget, (UInt32)maskAction, (UInt32)maskBank, maskOffset, nsmaskData, usedMask), "initWithParameterIndex:target:action:bank:offset:mask:used:");
			}
			NSString.ReleaseNative (nsmaskData);
			
		}
		
		[Export ("initWithParameterLength:target:action:bank:offset:mask:length:used:")]
		[CompilerGenerated]
		public AsSelectMaskParam (int index, MaskTargetType maskTarget, MaskActionType maskAction, MemoryBank maskBank, int maskOffset, string maskData, int maskLength, bool usedMask)
			: base (NSObjectFlag.Empty)
		{
			if (maskData == null)
				throw new ArgumentNullException ("maskData");
			var nsmaskData = NSString.CreateNative (maskData);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_UInt32_UInt32_UInt32_int_IntPtr_int_bool (this.Handle, Selector.GetHandle ("initWithParameterLength:target:action:bank:offset:mask:length:used:"), index, (UInt32)maskTarget, (UInt32)maskAction, (UInt32)maskBank, maskOffset, nsmaskData, maskLength, usedMask), "initWithParameterLength:target:action:bank:offset:mask:length:used:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_UInt32_UInt32_UInt32_int_IntPtr_int_bool (this.SuperHandle, Selector.GetHandle ("initWithParameterLength:target:action:bank:offset:mask:length:used:"), index, (UInt32)maskTarget, (UInt32)maskAction, (UInt32)maskBank, maskOffset, nsmaskData, maskLength, usedMask), "initWithParameterLength:target:action:bank:offset:mask:length:used:");
			}
			NSString.ReleaseNative (nsmaskData);
			
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		[Preserve (Conditional = true)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual MaskActionType Action {
			[Export ("action", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MaskActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("action"));
				} else {
					return (MaskActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("action"));
				}
			}
			
			[Export ("setAction:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAction:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAction:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MemoryBank Bank {
			[Export ("bank", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MemoryBank) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("bank"));
				} else {
					return (MemoryBank) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bank"));
				}
			}
			
			[Export ("setBank:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setBank:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setBank:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Index {
			[Export ("index")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("index"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("index"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Length {
			[Export ("length")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("length"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("length"));
				}
			}
			
			[Export ("setLength:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLength:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLength:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Mask {
			[Export ("mask", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mask")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mask")));
				}
			}
			
			[Export ("setMask:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMask:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMask:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int Offset {
			[Export ("offset")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("offset"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("offset"));
				}
			}
			
			[Export ("setOffset:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setOffset:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setOffset:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MaskTargetType Target {
			[Export ("target", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MaskTargetType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("target"));
				} else {
					return (MaskTargetType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("target"));
				}
			}
			
			[Export ("setTarget:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTarget:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTarget:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Used {
			[Export ("used")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("used"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("used"));
				}
			}
			
			[Export ("setUsed:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsed:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUsed:"), value);
				}
			}
		}
		
	} /* class AsSelectMaskParam */
}
