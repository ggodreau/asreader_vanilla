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
	[Register("AsDataUtil", true)]
	public unsafe partial class AsDataUtil : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsDataUtil");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsDataUtil () : base (NSObjectFlag.Empty)
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
		protected AsDataUtil (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsDataUtil (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dump:")]
		[CompilerGenerated]
		public static string Dump (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dump:"), data.Handle));
		}
		
		[Export ("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:")]
		[CompilerGenerated]
		public static NSRange FindDataWidthRange (NSData data, byte prefix, byte suffix1, byte suffix2)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			NSRange ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend_IntPtr_byte_byte_byte (class_ptr, Selector.GetHandle ("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:"), data.Handle, prefix, suffix1, suffix2);
				} else {
					global::ApiDefinition.Messaging.NSRange_objc_msgSend_stret_IntPtr_byte_byte_byte (out ret, class_ptr, Selector.GetHandle ("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:"), data.Handle, prefix, suffix1, suffix2);
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend_IntPtr_byte_byte_byte (class_ptr, Selector.GetHandle ("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:"), data.Handle, prefix, suffix1, suffix2);
			} else {
				ret = global::ApiDefinition.Messaging.NSRange_objc_msgSend_IntPtr_byte_byte_byte (class_ptr, Selector.GetHandle ("findDataWidthRange:withPrefix:withSuffix1:withSuffix2:"), data.Handle, prefix, suffix1, suffix2);
			}
			return ret;
		}
		
		[Export ("getHexString:")]
		[CompilerGenerated]
		public static string GetHexString (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getHexString:"), data.Handle));
		}
		
		[Export ("getHexString:offset:length:")]
		[CompilerGenerated]
		public static string GetHexString (NSData data, int offset, int length)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int_int (class_ptr, Selector.GetHandle ("getHexString:offset:length:"), data.Handle, offset, length));
		}
		
		[Export ("indexOf:find:")]
		[CompilerGenerated]
		public static nint IndexOf (NSData data, byte value)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_byte (class_ptr, Selector.GetHandle ("indexOf:find:"), data.Handle, value);
		}
		
		[Export ("indexOfWithArray:find:")]
		[CompilerGenerated]
		public static nint IndexOfWithArray (NSData data, NSData values)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (values == null)
				throw new ArgumentNullException ("values");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("indexOfWithArray:find:"), data.Handle, values.Handle);
		}
		
	} /* class AsDataUtil */
}
