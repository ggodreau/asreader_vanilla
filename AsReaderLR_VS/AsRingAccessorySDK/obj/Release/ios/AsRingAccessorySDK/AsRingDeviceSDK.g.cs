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

namespace AsRingAccessorySDK {
	[Register("AsRingDeviceSDK", true)]
	public unsafe partial class AsRingDeviceSDK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsRingDeviceSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsRingDeviceSDK () : base (NSObjectFlag.Empty)
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
		protected AsRingDeviceSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsRingDeviceSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addSDkMap:")]
		[CompilerGenerated]
		public virtual void AddSDkMap (NSDictionary addSDkMapDic)
		{
			if (addSDkMapDic == null)
				throw new ArgumentNullException ("addSDkMapDic");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addSDkMap:"), addSDkMapDic.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addSDkMap:"), addSDkMapDic.Handle);
			}
		}
		
		[Export ("asRingTx:")]
		[CompilerGenerated]
		public virtual void AsRingTx (NSData transmitData)
		{
			if (transmitData == null)
				throw new ArgumentNullException ("transmitData");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("asRingTx:"), transmitData.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("asRingTx:"), transmitData.Handle);
			}
		}
		
		[Export ("createFileWith:")]
		[CompilerGenerated]
		public virtual void CreateFileWith (FileModel file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createFileWith:"), file.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createFileWith:"), file.Handle);
			}
		}
		
		[Export ("createFloderWith:")]
		[CompilerGenerated]
		public virtual void CreateFloderWith (FloderModel floder)
		{
			if (floder == null)
				throw new ArgumentNullException ("floder");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createFloderWith:"), floder.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createFloderWith:"), floder.Handle);
			}
		}
		
		[Export ("deleteFileWith:")]
		[CompilerGenerated]
		public virtual void DeleteFileWith (FileModel file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteFileWith:"), file.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteFileWith:"), file.Handle);
			}
		}
		
		[Export ("deleteFloderWith:")]
		[CompilerGenerated]
		public virtual void DeleteFloderWith (FloderModel floder)
		{
			if (floder == null)
				throw new ArgumentNullException ("floder");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("deleteFloderWith:"), floder.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("deleteFloderWith:"), floder.Handle);
			}
		}
		
		[Export ("deviceDebug")]
		[CompilerGenerated]
		public virtual void DeviceDebug ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("deviceDebug"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceDebug"));
			}
		}
		
		[Export ("disConnect")]
		[CompilerGenerated]
		public virtual void DisConnect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disConnect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disConnect"));
			}
		}
		
		[Export ("disConnectWithAddress:")]
		[CompilerGenerated]
		public virtual void DisConnectWithAddress (string address)
		{
			if (address == null)
				throw new ArgumentNullException ("address");
			var nsaddress = NSString.CreateNative (address);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("disConnectWithAddress:"), nsaddress);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("disConnectWithAddress:"), nsaddress);
			}
			NSString.ReleaseNative (nsaddress);
			
		}
		
		[Export ("loadRootFloder")]
		[CompilerGenerated]
		public virtual void LoadRootFloder ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("loadRootFloder"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadRootFloder"));
			}
		}
		
		[Export ("modeTransition")]
		[CompilerGenerated]
		public virtual void ModeTransition ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("modeTransition"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("modeTransition"));
			}
		}
		
		[Export ("selectFileWith:")]
		[CompilerGenerated]
		public virtual void SelectFileWith (FileModel file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("selectFileWith:"), file.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("selectFileWith:"), file.Handle);
			}
		}
		
		[Export ("selectFloderWith:")]
		[CompilerGenerated]
		public virtual void SelectFloderWith (FloderModel floder)
		{
			if (floder == null)
				throw new ArgumentNullException ("floder");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("selectFloderWith:"), floder.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("selectFloderWith:"), floder.Handle);
			}
		}
		
		[Export ("setAsRingControlLogOn:")]
		[CompilerGenerated]
		public virtual void SetAsRingControlLogOn (bool on)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAsRingControlLogOn:"), on);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAsRingControlLogOn:"), on);
			}
		}
		
		[Export ("setAsRingLogOn:")]
		[CompilerGenerated]
		public virtual void SetAsRingLogOn (bool on)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAsRingLogOn:"), on);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAsRingLogOn:"), on);
			}
		}
		
		[Export ("tX:msg_type:cmd_code:")]
		[CompilerGenerated]
		public virtual void TX (NSData sendData, byte msg_type, byte cmd_code)
		{
			if (sendData == null)
				throw new ArgumentNullException ("sendData");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_byte_byte (this.Handle, Selector.GetHandle ("tX:msg_type:cmd_code:"), sendData.Handle, msg_type, cmd_code);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_byte_byte (this.SuperHandle, Selector.GetHandle ("tX:msg_type:cmd_code:"), sendData.Handle, msg_type, cmd_code);
			}
		}
		
		[Export ("transmitData:sdk:")]
		[CompilerGenerated]
		public virtual void TransmitData (NSData transmitData, AsRingAccessoryBaseSDK sdk)
		{
			if (transmitData == null)
				throw new ArgumentNullException ("transmitData");
			if (sdk == null)
				throw new ArgumentNullException ("sdk");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("transmitData:sdk:"), transmitData.Handle, sdk.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("transmitData:sdk:"), transmitData.Handle, sdk.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] AllConnectDevice {
			[Export ("getAllConnectDevice")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAllConnectDevice")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAllConnectDevice")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] AllDevice {
			[Export ("getAllDevice")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAllDevice")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAllDevice")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string AsRingFirmwareRevision {
			[Export ("getAsRingFirmwareRevision")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAsRingFirmwareRevision")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAsRingFirmwareRevision")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string AsRingHardwareRevision {
			[Export ("getAsRingHardwareRevision")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAsRingHardwareRevision")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAsRingHardwareRevision")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string AsRingModelNumber {
			[Export ("getAsRingModelNumber")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAsRingModelNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAsRingModelNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string AsRingSDKVersion {
			[Export ("getAsRingSDKVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAsRingSDKVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAsRingSDKVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string AsRingSerialNumber {
			[Export ("getAsRingSerialNumber")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAsRingSerialNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAsRingSerialNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DebugListener_var;
		[CompilerGenerated]
		public virtual AsRingDebugListener DebugListener {
			[Export ("debugListener", ArgumentSemantic.Weak)]
			get {
				AsRingDebugListener ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AsRingDebugListener> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("debugListener")));
				} else {
					ret =  Runtime.GetNSObject<AsRingDebugListener> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("debugListener")));
				}
				MarkDirty ();
				__mt_DebugListener_var = ret;
				return ret;
			}
			
			[Export ("setDebugListener:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDebugListener:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDebugListener:"), value.Handle);
				}
				MarkDirty ();
				__mt_DebugListener_var = value;
			}
		}
		
		[CompilerGenerated]
		public AsRingDeviceSDKDelegate Delegate {
			get {
				return WeakDelegate as AsRingDeviceSDKDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsOpened {
			[Export ("isOpened")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isOpened"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isOpened"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static AsRingDeviceSDK SharedAsRingDeviceSDK {
			[Export ("sharedAsRingDeviceSDK")]
			get {
				AsRingDeviceSDK ret;
				ret =  Runtime.GetNSObject<AsRingDeviceSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedAsRingDeviceSDK")));
				return ret;
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
				__mt_DebugListener_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class AsRingDeviceSDK */
}
