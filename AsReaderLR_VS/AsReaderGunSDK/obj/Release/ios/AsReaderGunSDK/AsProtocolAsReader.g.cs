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
	[Register("AsProtocolAsReader", true)]
	public unsafe partial class AsProtocolAsReader : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsProtocolAsReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsProtocolAsReader () : base (NSObjectFlag.Empty)
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
		protected AsProtocolAsReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsProtocolAsReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAsReaderGUN:delegate:")]
		[CompilerGenerated]
		public AsProtocolAsReader (AsReaderGUN asReaderGUN, AsReaderDelegate receiver)
			: base (NSObjectFlag.Empty)
		{
			if (asReaderGUN == null)
				throw new ArgumentNullException ("asReaderGUN");
			if (receiver == null)
				throw new ArgumentNullException ("receiver");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAsReaderGUN:delegate:"), asReaderGUN.Handle, receiver.Handle), "initWithAsReaderGUN:delegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAsReaderGUN:delegate:"), asReaderGUN.Handle, receiver.Handle), "initWithAsReaderGUN:delegate:");
			}
		}
		
		[Export ("command:")]
		[CompilerGenerated]
		public virtual ResultCode Command (CommandType command)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("command:"), (UInt32)command);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("command:"), (UInt32)command);
			}
		}
		
		[Export ("command:withParameter:")]
		[CompilerGenerated]
		public virtual ResultCode Command (CommandType command, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("command:withParameter:"), (UInt32)command, nsparam);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("command:withParameter:"), (UInt32)command, nsparam);
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("commandSync:withParameter:")]
		[CompilerGenerated]
		public virtual AsResultData CommandSync (CommandType command, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			AsResultData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("commandSync:withParameter:"), (UInt32)command, nsparam));
			} else {
				ret =  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("commandSync:withParameter:"), (UInt32)command, nsparam));
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("debug:")]
		[CompilerGenerated]
		public virtual ResultCode Debug (DebugType debugType)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("debug:"), (UInt32)debugType);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("debug:"), (UInt32)debugType);
			}
		}
		
		[Export ("debug:withParameter:")]
		[CompilerGenerated]
		public virtual ResultCode Debug (DebugType debugType, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("debug:withParameter:"), (UInt32)debugType, nsparam);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("debug:withParameter:"), (UInt32)debugType, nsparam);
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("debugSync:withParameter:")]
		[CompilerGenerated]
		public virtual AsResultData DebugSync (DebugType command, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			AsResultData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("debugSync:withParameter:"), (UInt32)command, nsparam));
			} else {
				ret =  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("debugSync:withParameter:"), (UInt32)command, nsparam));
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disconnect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnect"));
			}
		}
		
		[Export ("getBarcodeProperty:withParameter:")]
		[CompilerGenerated]
		public virtual NSData GetBarcodeProperty (PropertyType type, NSData param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("getBarcodeProperty:withParameter:"), (UInt32)type, param.Handle));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("getBarcodeProperty:withParameter:"), (UInt32)type, param.Handle));
			}
		}
		
		[Export ("getProperty:")]
		[CompilerGenerated]
		public virtual string GetProperty (PropertyType type)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("getProperty:"), (UInt32)type));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("getProperty:"), (UInt32)type));
			}
		}
		
		[Export ("getProperty:withParameter:")]
		[CompilerGenerated]
		public virtual string GetProperty (PropertyType type, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("getProperty:withParameter:"), (UInt32)type, nsparam));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("getProperty:withParameter:"), (UInt32)type, nsparam));
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("postSSI:")]
		[CompilerGenerated]
		public virtual ResultCode PostSSI (SSICommand command)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("postSSI:"), (UInt32)command);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("postSSI:"), (UInt32)command);
			}
		}
		
		[Export ("postSSI:withData:")]
		[CompilerGenerated]
		public virtual ResultCode PostSSI (SSICommand command, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("postSSI:withData:"), (UInt32)command, data.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("postSSI:withData:"), (UInt32)command, data.Handle);
			}
		}
		
		[Export ("receiveData")]
		[CompilerGenerated]
		public virtual void ReceiveData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("receiveData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiveData"));
			}
		}
		
		[Export ("sendSSI:")]
		[CompilerGenerated]
		public virtual AsResultData SendSSI (SSICommand command)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("sendSSI:"), (UInt32)command));
			} else {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("sendSSI:"), (UInt32)command));
			}
		}
		
		[Export ("sendSSI:withData:")]
		[CompilerGenerated]
		public virtual AsResultData SendSSI (SSICommand command, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("sendSSI:withData:"), (UInt32)command, data.Handle));
			} else {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("sendSSI:withData:"), (UInt32)command, data.Handle));
			}
		}
		
		[Export ("setBarcodeContinueMode:")]
		[CompilerGenerated]
		public virtual void SetBarcodeContinueMode (bool isContinueMode)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBarcodeContinueMode:"), isContinueMode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBarcodeContinueMode:"), isContinueMode);
			}
		}
		
		[Export ("setBarcodeProperty:withParameter:")]
		[CompilerGenerated]
		public virtual AsResultData SetBarcodeProperty (PropertyType type, NSData param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("setBarcodeProperty:withParameter:"), (UInt32)type, param.Handle));
			} else {
				return  Runtime.GetNSObject<AsResultData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarcodeProperty:withParameter:"), (UInt32)type, param.Handle));
			}
		}
		
		[Export ("setProperty:")]
		[CompilerGenerated]
		public virtual ResultCode SetProperty (PropertyType type)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setProperty:"), (UInt32)type);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setProperty:"), (UInt32)type);
			}
		}
		
		[Export ("setProperty:withParameter:")]
		[CompilerGenerated]
		public virtual ResultCode SetProperty (PropertyType type, string param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			var nsparam = NSString.CreateNative (param);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_IntPtr (this.Handle, Selector.GetHandle ("setProperty:withParameter:"), (UInt32)type, nsparam);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_IntPtr (this.SuperHandle, Selector.GetHandle ("setProperty:withParameter:"), (UInt32)type, nsparam);
			}
			NSString.ReleaseNative (nsparam);
			
			return ret;
		}
		
		[Export ("setReaderType:")]
		[CompilerGenerated]
		public virtual void SetReaderType (ReaderType readertype)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setReaderType:"), (UInt32)readertype);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setReaderType:"), (UInt32)readertype);
			}
		}
		
		[Export ("wakeUpBarcode")]
		[CompilerGenerated]
		public virtual void WakeUpBarcode ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("wakeUpBarcode"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wakeUpBarcode"));
			}
		}
		
		[CompilerGenerated]
		public virtual CommandType Action {
			[Export ("getAction")]
			get {
				if (IsDirectBinding) {
					return (CommandType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getAction"));
				} else {
					return (CommandType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAction"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DataType {
			[Export ("dataType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("dataType"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataType"));
				}
			}
			
			[Export ("setDataType:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDataType:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDataType:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public AsReaderDelegate Delegate {
			get {
				return WeakDelegate as AsReaderDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsBarcodeMode {
			[Export ("isBarcodeMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBarcodeMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBarcodeMode"));
				}
			}
			
			[Export ("setIsBarcodeMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsBarcodeMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsBarcodeMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsReportRssi {
			[Export ("isReportRssi")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReportRssi"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isReportRssi"));
				}
			}
			
			[Export ("setIsReportRssi:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsReportRssi:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsReportRssi:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ScanMode ScanMode {
			[Export ("scanMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (ScanMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("scanMode"));
				} else {
					return (ScanMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scanMode"));
				}
			}
			
			[Export ("setScanMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setScanMode:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setScanMode:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int VersionCode {
			[Export ("versionCode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("versionCode"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("versionCode"));
				}
			}
			
			[Export ("setVersionCode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setVersionCode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setVersionCode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AsProtocolAsReader */
}
