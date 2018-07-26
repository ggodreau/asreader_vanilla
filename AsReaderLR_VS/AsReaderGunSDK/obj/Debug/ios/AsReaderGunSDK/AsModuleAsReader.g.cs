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
	[Register("AsModuleAsReader", true)]
	public unsafe partial class AsModuleAsReader : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsModuleAsReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsModuleAsReader () : base (NSObjectFlag.Empty)
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
		protected AsModuleAsReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsModuleAsReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithProtocol:")]
		[CompilerGenerated]
		public AsModuleAsReader (AsProtocolAsReader protocol)
			: base (NSObjectFlag.Empty)
		{
			if (protocol == null)
				throw new ArgumentNullException ("protocol");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithProtocol:"), protocol.Handle), "initWithProtocol:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithProtocol:"), protocol.Handle), "initWithProtocol:");
			}
		}
		
		[Export ("addEpcMask:")]
		[CompilerGenerated]
		public virtual void AddEpcMask (AsSelectMaskEPCParam param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addEpcMask:"), param.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addEpcMask:"), param.Handle);
			}
		}
		
		[Export ("blockErase:offset:length:")]
		[CompilerGenerated]
		public virtual ResultCode BlockErase (MemoryBank bank, int offset, int length)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_int_int (this.Handle, Selector.GetHandle ("blockErase:offset:length:"), (UInt32)bank, offset, length);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_int_int (this.SuperHandle, Selector.GetHandle ("blockErase:offset:length:"), (UInt32)bank, offset, length);
			}
		}
		
		[Export ("blockWrite:offset:value:")]
		[CompilerGenerated]
		public virtual ResultCode BlockWrite (MemoryBank bank, int offset, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_int_IntPtr (this.Handle, Selector.GetHandle ("blockWrite:offset:value:"), (UInt32)bank, offset, nsvalue);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_int_IntPtr (this.SuperHandle, Selector.GetHandle ("blockWrite:offset:value:"), (UInt32)bank, offset, nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
			return ret;
		}
		
		[Export ("clearEpcMask")]
		[CompilerGenerated]
		public virtual void ClearEpcMask ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearEpcMask"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearEpcMask"));
			}
		}
		
		[Export ("getBarcodeMode")]
		[CompilerGenerated]
		public virtual bool GetBarcodeMode ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getBarcodeMode"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBarcodeMode"));
			}
		}
		
		[Export ("getBarcodeParam:")]
		[CompilerGenerated]
		public virtual NSData GetBarcodeParam (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getBarcodeParam:"), data.Handle));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getBarcodeParam:"), data.Handle));
			}
		}
		
		[Export ("getBarcodeState")]
		[CompilerGenerated]
		public virtual int GetBarcodeState ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getBarcodeState"));
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBarcodeState"));
			}
		}
		
		[Export ("getDebugConfig:")]
		[CompilerGenerated]
		public virtual bool GetDebugConfig (string barcode)
		{
			if (barcode == null)
				throw new ArgumentNullException ("barcode");
			var nsbarcode = NSString.CreateNative (barcode);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getDebugConfig:"), nsbarcode);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getDebugConfig:"), nsbarcode);
			}
			NSString.ReleaseNative (nsbarcode);
			
			return ret;
		}
		
		[Export ("getEpcMask:")]
		[CompilerGenerated]
		public virtual AsSelectMaskEPCParam GetEpcMask (int index)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsSelectMaskEPCParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getEpcMask:"), index));
			} else {
				return  Runtime.GetNSObject<AsSelectMaskEPCParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getEpcMask:"), index));
			}
		}
		
		[Export ("getLBTFrequency:")]
		[CompilerGenerated]
		public virtual ulong GetLBTFrequency (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.UInt64_objc_msgSend_int (this.Handle, Selector.GetHandle ("getLBTFrequency:"), index);
			} else {
				return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getLBTFrequency:"), index);
			}
		}
		
		[Export ("getMask:")]
		[CompilerGenerated]
		public virtual NSObject[] GetMask (int index)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMask:"), index));
			} else {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMask:"), index));
			}
		}
		
		[Export ("getMaskAction:")]
		[CompilerGenerated]
		public virtual MaskActionType GetMaskAction (int index)
		{
			if (IsDirectBinding) {
				return (MaskActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMaskAction:"), index);
			} else {
				return (MaskActionType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMaskAction:"), index);
			}
		}
		
		[Export ("getMaskBank:")]
		[CompilerGenerated]
		public virtual MemoryBank GetMaskBank (int index)
		{
			if (IsDirectBinding) {
				return (MemoryBank) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMaskBank:"), index);
			} else {
				return (MemoryBank) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMaskBank:"), index);
			}
		}
		
		[Export ("getMaskOffset:")]
		[CompilerGenerated]
		public virtual int GetMaskOffset (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMaskOffset:"), index);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMaskOffset:"), index);
			}
		}
		
		[Export ("getMaskTarget:")]
		[CompilerGenerated]
		public virtual MaskTargetType GetMaskTarget (int index)
		{
			if (IsDirectBinding) {
				return (MaskTargetType) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMaskTarget:"), index);
			} else {
				return (MaskTargetType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMaskTarget:"), index);
			}
		}
		
		[Export ("getMaskUsed:")]
		[CompilerGenerated]
		public virtual bool GetMaskUsed (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("getMaskUsed:"), index);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getMaskUsed:"), index);
			}
		}
		
		[Export ("kill:")]
		[CompilerGenerated]
		public virtual ResultCode Kill (string killPassword)
		{
			if (killPassword == null)
				throw new ArgumentNullException ("killPassword");
			var nskillPassword = NSString.CreateNative (killPassword);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("kill:"), nskillPassword);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("kill:"), nskillPassword);
			}
			NSString.ReleaseNative (nskillPassword);
			
			return ret;
		}
		
		[Export ("lock:mask:")]
		[CompilerGenerated]
		public virtual ResultCode Lock (int action, int mask)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("lock:mask:"), action, mask);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("lock:mask:"), action, mask);
			}
		}
		
		[Export ("permaLock:mask:")]
		[CompilerGenerated]
		public virtual ResultCode PermaLock (int action, int mask)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("permaLock:mask:"), action, mask);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("permaLock:mask:"), action, mask);
			}
		}
		
		[Export ("readMemory:offset:length:")]
		[CompilerGenerated]
		public virtual ResultCode ReadMemory (MemoryBank bank, int offset, int length)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_int_int (this.Handle, Selector.GetHandle ("readMemory:offset:length:"), (UInt32)bank, offset, length);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_int_int (this.SuperHandle, Selector.GetHandle ("readMemory:offset:length:"), (UInt32)bank, offset, length);
			}
		}
		
		[Export ("saveEpcMask")]
		[CompilerGenerated]
		public virtual void SaveEpcMask ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("saveEpcMask"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveEpcMask"));
			}
		}
		
		[Export ("saveStoredTag:")]
		[CompilerGenerated]
		public virtual ResultCode SaveStoredTag (string tag)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("saveStoredTag:"), nstag);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("saveStoredTag:"), nstag);
			}
			NSString.ReleaseNative (nstag);
			
			return ret;
		}
		
		[Export ("setBarcodeParam:")]
		[CompilerGenerated]
		public virtual ResultCode SetBarcodeParam (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarcodeParam:"), data.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarcodeParam:"), data.Handle);
			}
		}
		
		[Export ("setDebugMode:")]
		[CompilerGenerated]
		public virtual void SetDebugMode (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDebugMode:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDebugMode:"), enabled);
			}
		}
		
		[Export ("setEpcMaskMatchMode:")]
		[CompilerGenerated]
		public virtual void SetEpcMaskMatchMode (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEpcMaskMatchMode:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEpcMaskMatchMode:"), enabled);
			}
		}
		
		[Export ("setLBT:")]
		[CompilerGenerated]
		public virtual void SetLBT (nint table)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setLBT:"), table);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setLBT:"), table);
			}
		}
		
		[Export ("setMask:mask:")]
		[CompilerGenerated]
		public virtual void SetMask (int index, string mask)
		{
			if (mask == null)
				throw new ArgumentNullException ("mask");
			var nsmask = NSString.CreateNative (mask);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("setMask:mask:"), index, nsmask);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("setMask:mask:"), index, nsmask);
			}
			NSString.ReleaseNative (nsmask);
			
		}
		
		[Export ("setMask:mask:length:")]
		[CompilerGenerated]
		public virtual void SetMask (int index, string mask, int length)
		{
			if (mask == null)
				throw new ArgumentNullException ("mask");
			var nsmask = NSString.CreateNative (mask);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr_int (this.Handle, Selector.GetHandle ("setMask:mask:length:"), index, nsmask, length);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr_int (this.SuperHandle, Selector.GetHandle ("setMask:mask:length:"), index, nsmask, length);
			}
			NSString.ReleaseNative (nsmask);
			
		}
		
		[Export ("setMaskAction:maskActionType:")]
		[CompilerGenerated]
		public virtual void SetMaskAction (int index, MaskActionType action)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_UInt32 (this.Handle, Selector.GetHandle ("setMaskAction:maskActionType:"), index, (UInt32)action);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_UInt32 (this.SuperHandle, Selector.GetHandle ("setMaskAction:maskActionType:"), index, (UInt32)action);
			}
		}
		
		[Export ("setMaskBank:maskBank:")]
		[CompilerGenerated]
		public virtual void SetMaskBank (int index, MemoryBank bank)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_UInt32 (this.Handle, Selector.GetHandle ("setMaskBank:maskBank:"), index, (UInt32)bank);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_UInt32 (this.SuperHandle, Selector.GetHandle ("setMaskBank:maskBank:"), index, (UInt32)bank);
			}
		}
		
		[Export ("setMaskOffset:maskOffset:")]
		[CompilerGenerated]
		public virtual void SetMaskOffset (int index, int offset)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("setMaskOffset:maskOffset:"), index, offset);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("setMaskOffset:maskOffset:"), index, offset);
			}
		}
		
		[Export ("setMaskTarget:maskTargetType:")]
		[CompilerGenerated]
		public virtual void SetMaskTarget (int index, MaskTargetType target)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_UInt32 (this.Handle, Selector.GetHandle ("setMaskTarget:maskTargetType:"), index, (UInt32)target);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_UInt32 (this.SuperHandle, Selector.GetHandle ("setMaskTarget:maskTargetType:"), index, (UInt32)target);
			}
		}
		
		[Export ("setMaskUsed:used:")]
		[CompilerGenerated]
		public virtual void SetMaskUsed (int index, bool used)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_bool (this.Handle, Selector.GetHandle ("setMaskUsed:used:"), index, used);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, Selector.GetHandle ("setMaskUsed:used:"), index, used);
			}
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
		
		[Export ("setTagDataType:")]
		[CompilerGenerated]
		public virtual void SetTagDataType (int tagData)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTagDataType:"), tagData);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTagDataType:"), tagData);
			}
		}
		
		[Export ("setVersionCode:")]
		[CompilerGenerated]
		public virtual void SetVersionCode (int versionCode)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setVersionCode:"), versionCode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setVersionCode:"), versionCode);
			}
		}
		
		[Export ("writeMemory:offset:value:")]
		[CompilerGenerated]
		public virtual ResultCode WriteMemory (MemoryBank bank, int offset, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_UInt32_int_IntPtr (this.Handle, Selector.GetHandle ("writeMemory:offset:value:"), (UInt32)bank, offset, nsvalue);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_UInt32_int_IntPtr (this.SuperHandle, Selector.GetHandle ("writeMemory:offset:value:"), (UInt32)bank, offset, nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual int BarcodePowerState {
			[Export ("barcodePowerState")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("barcodePowerState"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("barcodePowerState"));
				}
			}
			
			[Export ("setBarcodePowerState:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setBarcodePowerState:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setBarcodePowerState:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ulong EpcMaskCount {
			[Export ("getEpcMaskCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("getEpcMaskCount"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEpcMaskCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool EpcMaskMatchMode {
			[Export ("getEpcMaskMatchMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getEpcMaskMatchMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEpcMaskMatchMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FirmwareVersion {
			[Export ("firmwareVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firmwareVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firmwareVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ulong LBT {
			[Export ("getLBT")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("getLBT"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLBT"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ulong LBTMask {
			[Export ("getLBTMask")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("getLBTMask"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLBTMask"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual CMinMaxValue PowerGainRange {
			[Export ("powerGainRange")]
			get {
				CMinMaxValue ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSend (this.Handle, Selector.GetHandle ("powerGainRange"));
						} else {
							global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("powerGainRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSend (this.Handle, Selector.GetHandle ("powerGainRange"));
					} else {
						ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSend (this.Handle, Selector.GetHandle ("powerGainRange"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerGainRange"));
						} else {
							global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("powerGainRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerGainRange"));
					} else {
						ret = global::ApiDefinition.Messaging.CMinMaxValue_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerGainRange"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string RegionName {
			[Export ("regionName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("regionName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("regionName")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string UHFVersion {
			[Export ("UHFVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("UHFVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("UHFVersion")));
				}
			}
			
		}
		
	} /* class AsModuleAsReader */
}
