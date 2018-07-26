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
	[Register("AsReader", true)]
	public unsafe partial class AsReader : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsReader () : base (NSObjectFlag.Empty)
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
		protected AsReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAsReaderGUN:delegate:")]
		[CompilerGenerated]
		public AsReader (AsReaderGUN device, AsReaderDelegate @delegate)
			: base (NSObjectFlag.Empty)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAsReaderGUN:delegate:"), device.Handle, @delegate.Handle), "initWithAsReaderGUN:delegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAsReaderGUN:delegate:"), device.Handle, @delegate.Handle), "initWithAsReaderGUN:delegate:");
			}
		}
		
		[Export ("addEpcMask:length:mask:")]
		[CompilerGenerated]
		public virtual ResultCode AddEpcMask (int offset, int length, string mask)
		{
			if (mask == null)
				throw new ArgumentNullException ("mask");
			var nsmask = NSString.CreateNative (mask);
			
			ResultCode ret;
			if (IsDirectBinding) {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int_int_IntPtr (this.Handle, Selector.GetHandle ("addEpcMask:length:mask:"), offset, length, nsmask);
			} else {
				ret = (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int_int_IntPtr (this.SuperHandle, Selector.GetHandle ("addEpcMask:length:mask:"), offset, length, nsmask);
			}
			NSString.ReleaseNative (nsmask);
			
			return ret;
		}
		
		[Export ("addEpcMask:")]
		[CompilerGenerated]
		public virtual ResultCode AddEpcMask (AsSelectMaskEPCParam mask)
		{
			if (mask == null)
				throw new ArgumentNullException ("mask");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addEpcMask:"), mask.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addEpcMask:"), mask.Handle);
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
		
		[Export ("clearSelectionMask")]
		[CompilerGenerated]
		public virtual void ClearSelectionMask ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearSelectionMask"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearSelectionMask"));
			}
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
		
		[Export ("getBarcodeParam:")]
		[CompilerGenerated]
		public virtual AsParamValue GetBarcodeParam (NSNumber paramData)
		{
			if (paramData == null)
				throw new ArgumentNullException ("paramData");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsParamValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getBarcodeParam:"), paramData.Handle));
			} else {
				return  Runtime.GetNSObject<AsParamValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getBarcodeParam:"), paramData.Handle));
			}
		}
		
		[Export ("getBarcodeParams:")]
		[CompilerGenerated]
		public virtual NSObject[] GetBarcodeParams (NSObject[] paramData)
		{
			if (paramData == null)
				throw new ArgumentNullException ("paramData");
			var nsa_paramData = NSArray.FromNSObjects (paramData);
			
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getBarcodeParams:"), nsa_paramData.Handle));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getBarcodeParams:"), nsa_paramData.Handle));
			}
			nsa_paramData.Dispose ();
			
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
		public virtual string GetLBTFrequency (int slot)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getLBTFrequency:"), slot));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getLBTFrequency:"), slot));
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
		
		[Export ("getSelectionMask:")]
		[CompilerGenerated]
		public virtual AsSelectMaskParam GetSelectionMask (int index)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsSelectMaskParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getSelectionMask:"), index));
			} else {
				return  Runtime.GetNSObject<AsSelectMaskParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getSelectionMask:"), index));
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
		
		[Export ("lock:")]
		[CompilerGenerated]
		public virtual ResultCode Lock (LockParam param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("lock:"), param.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("lock:"), param.Handle);
			}
		}
		
		[Export ("permaLock:")]
		[CompilerGenerated]
		public virtual ResultCode PermaLock (LockParam param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("permaLock:"), param.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("permaLock:"), param.Handle);
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
		
		[Export ("removeSelectionMask:")]
		[CompilerGenerated]
		public virtual void RemoveSelectionMask (int index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("removeSelectionMask:"), index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("removeSelectionMask:"), index);
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
		
		[Export ("setBarcodeMode:isKeyAction:")]
		[CompilerGenerated]
		public virtual ResultCode SetBarcodeMode (bool enabled, bool isKeyOn)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setBarcodeMode:isKeyAction:"), enabled, isKeyOn);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setBarcodeMode:isKeyAction:"), enabled, isKeyOn);
			}
		}
		
		[Export ("setBarcodeParam:")]
		[CompilerGenerated]
		public virtual ResultCode SetBarcodeParam (AsParamValue paramData)
		{
			if (paramData == null)
				throw new ArgumentNullException ("paramData");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBarcodeParam:"), paramData.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBarcodeParam:"), paramData.Handle);
			}
		}
		
		[Export ("setDebugMode:")]
		[CompilerGenerated]
		public virtual ResultCode SetDebugMode (bool enabled)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDebugMode:"), enabled);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDebugMode:"), enabled);
			}
		}
		
		[Export ("setDelegate:")]
		[CompilerGenerated]
		public virtual void SetDelegate (AsReaderDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setLBT:")]
		[CompilerGenerated]
		public virtual void SetLBT (NSObject[] table)
		{
			if (table == null)
				throw new ArgumentNullException ("table");
			var nsa_table = NSArray.FromNSObjects (table);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLBT:"), nsa_table.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLBT:"), nsa_table.Handle);
			}
			nsa_table.Dispose ();
			
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
		
		[Export ("setPropBarcodeMode:")]
		[CompilerGenerated]
		public virtual void SetPropBarcodeMode (bool mode)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPropBarcodeMode:"), mode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPropBarcodeMode:"), mode);
			}
		}
		
		[Export ("setRegister:")]
		[CompilerGenerated]
		public virtual void SetRegister (string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRegister:"), nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRegister:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("setScanMode:")]
		[CompilerGenerated]
		public virtual void SetScanMode (ScanMode scanMode)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setScanMode:"), (UInt32)scanMode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setScanMode:"), (UInt32)scanMode);
			}
		}
		
		[Export ("setSelectionMask:withParam:")]
		[CompilerGenerated]
		public virtual void SetSelectionMask (int index, AsSelectMaskParam param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("setSelectionMask:withParam:"), index, param.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectionMask:withParam:"), index, param.Handle);
			}
		}
		
		[Export ("setTagDataType:")]
		[CompilerGenerated]
		public virtual void SetTagDataType (int value)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTagDataType:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTagDataType:"), value);
			}
		}
		
		[Export ("startBuzzerWithBuzzerTime:")]
		[CompilerGenerated]
		public virtual ResultCode StartBuzzerWithBuzzerTime (int buzzerTime)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("startBuzzerWithBuzzerTime:"), buzzerTime);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("startBuzzerWithBuzzerTime:"), buzzerTime);
			}
		}
		
		[Export ("startVibratorWithVibratorTime:")]
		[CompilerGenerated]
		public virtual ResultCode StartVibratorWithVibratorTime (int vibratorTime)
		{
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_int (this.Handle, Selector.GetHandle ("startVibratorWithVibratorTime:"), vibratorTime);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("startVibratorWithVibratorTime:"), vibratorTime);
			}
		}
		
		[Export ("unlock:")]
		[CompilerGenerated]
		public virtual ResultCode Unlock (LockParam param)
		{
			if (param == null)
				throw new ArgumentNullException ("param");
			if (IsDirectBinding) {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unlock:"), param.Handle);
			} else {
				return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unlock:"), param.Handle);
			}
		}
		
		[Export ("usedSelectionMask:")]
		[CompilerGenerated]
		public virtual bool UsedSelectionMask (int index)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("usedSelectionMask:"), index);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("usedSelectionMask:"), index);
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
		public virtual string AccessPassword {
			[Export ("accessPassword", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessPassword")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessPassword")));
				}
			}
			
			[Export ("setAccessPassword:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessPassword:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessPassword:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
		public virtual ResultCode AimOff {
			[Export ("aimOff")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("aimOff"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("aimOff"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode AimOn {
			[Export ("aimOn")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("aimOn"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("aimOn"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual AlgorithmType Algorithm {
			[Export ("algorithm", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (AlgorithmType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("algorithm"));
				} else {
					return (AlgorithmType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("algorithm"));
				}
			}
			
			[Export ("setAlgorithm:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setAlgorithm:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setAlgorithm:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int AutoOffTime {
			[Export ("autoOffTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("autoOffTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autoOffTime"));
				}
			}
			
			[Export ("setAutoOffTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAutoOffTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAutoOffTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int BatteryStatus {
			[Export ("batteryStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("batteryStatus"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("batteryStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual BuzzerState Buzzer {
			[Export ("buzzer", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (BuzzerState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("buzzer"));
				} else {
					return (BuzzerState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buzzer"));
				}
			}
			
			[Export ("setBuzzer:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setBuzzer:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setBuzzer:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode ClearEpcMask {
			[Export ("clearEpcMask")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("clearEpcMask"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearEpcMask"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ContinuousMode {
			[Export ("continuousMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("continuousMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continuousMode"));
				}
			}
			
			[Export ("setContinuousMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setContinuousMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setContinuousMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int DefaultLinkProfileValue {
			[Export ("defaultLinkProfileValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("defaultLinkProfileValue"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultLinkProfileValue"));
				}
			}
			
			[Export ("setDefaultLinkProfileValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDefaultLinkProfileValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDefaultLinkProfileValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode DefaultParameter {
			[Export ("defaultParameter")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("defaultParameter"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("defaultParameter"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode EnterBarcodeBypassMode {
			[Export ("enterBarcodeBypassMode")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("enterBarcodeBypassMode"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enterBarcodeBypassMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode EnterBypassMode {
			[Export ("enterBypassMode")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("enterBypassMode"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enterBypassMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int EpcMaskCount {
			[Export ("epcMaskCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("epcMaskCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("epcMaskCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool EpcMaskMatchMode {
			[Export ("epcMaskMatchMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("epcMaskMatchMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("epcMaskMatchMode"));
				}
			}
			
			[Export ("setEpcMaskMatchMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEpcMaskMatchMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEpcMaskMatchMode:"), value);
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
		public virtual ResultCode HardReset {
			[Export ("hardReset")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("hardReset"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hardReset"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int IdleTime {
			[Export ("idleTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("idleTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("idleTime"));
				}
			}
			
			[Export ("setIdleTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setIdleTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setIdleTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode Inventory {
			[Export ("inventory")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("inventory"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inventory"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual SessionType InventorySession {
			[Export ("inventorySession", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (SessionType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("inventorySession"));
				} else {
					return (SessionType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inventorySession"));
				}
			}
			
			[Export ("setInventorySession:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setInventorySession:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setInventorySession:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int InventoryTime {
			[Export ("inventoryTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("inventoryTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inventoryTime"));
				}
			}
			
			[Export ("setInventoryTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setInventoryTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setInventoryTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsBarcodeModule {
			[Export ("isBarcodeModule")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isBarcodeModule"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isBarcodeModule"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRFIDModule {
			[Export ("isRFIDModule")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRFIDModule"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRFIDModule"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsUseKeyAction {
			[Export ("isUseKeyAction")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUseKeyAction"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUseKeyAction"));
				}
			}
			
			[Export ("setIsUseKeyAction:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsUseKeyAction:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsUseKeyAction:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject[] LBT {
			[Export ("getLBT")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getLBT")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLBT")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] LBTMask {
			[Export ("getLBTMask")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getLBTMask")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLBTMask")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode LeaveBypassMode {
			[Export ("leaveBypassMode")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("leaveBypassMode"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leaveBypassMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode LedOff {
			[Export ("ledOff")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("ledOff"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ledOff"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode LedOn {
			[Export ("ledOn")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("ledOn"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ledOn"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int LimitTagCount {
			[Export ("limitTagCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("limitTagCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("limitTagCount"));
				}
			}
			
			[Export ("setLimitTagCount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLimitTagCount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLimitTagCount:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int LinkProfileValue {
			[Export ("linkProfileValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("linkProfileValue"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("linkProfileValue"));
				}
			}
			
			[Export ("setLinkProfileValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLinkProfileValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLinkProfileValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode LoadDebugMessage {
			[Export ("loadDebugMessage")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("loadDebugMessage"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("loadDebugMessage"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual AsReaderGUN MAsReaderGUN {
			[Export ("mAsReaderGUN", ArgumentSemantic.Retain)]
			get {
				AsReaderGUN ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AsReaderGUN> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mAsReaderGUN")));
				} else {
					ret =  Runtime.GetNSObject<AsReaderGUN> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mAsReaderGUN")));
				}
				return ret;
			}
			
			[Export ("setMAsReaderGUN:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMAsReaderGUN:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMAsReaderGUN:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int MaskTypeValue {
			[Export ("maskTypeValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("maskTypeValue"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maskTypeValue"));
				}
			}
			
			[Export ("setMaskTypeValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMaskTypeValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMaskTypeValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int MaxQ {
			[Export ("maxQ")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("maxQ"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxQ"));
				}
			}
			
			[Export ("setMaxQ:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMaxQ:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMaxQ:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int MinQ {
			[Export ("minQ")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("minQ"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minQ"));
				}
			}
			
			[Export ("setMinQ:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setMinQ:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setMinQ:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int OperationTime {
			[Export ("operationTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("operationTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("operationTime"));
				}
			}
			
			[Export ("setOperationTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setOperationTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setOperationTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int PowerGain {
			[Export ("powerGain")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("powerGain"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerGain"));
				}
			}
			
			[Export ("setPowerGain:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPowerGain:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPowerGain:"), value);
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
		public virtual int QValue {
			[Export ("qValue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("qValue"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("qValue"));
				}
			}
			
			[Export ("setQValue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setQValue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setQValue:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string RFModuleVersion {
			[Export ("rFModuleVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rFModuleVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rFModuleVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ReaderType ReaderType {
			[Export ("getReaderType")]
			get {
				if (IsDirectBinding) {
					return (ReaderType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getReaderType"));
				} else {
					return (ReaderType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getReaderType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual RegionType Region {
			[Export ("region", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (RegionType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("region"));
				} else {
					return (RegionType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("region"));
				}
			}
			
			[Export ("setRegion:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setRegion:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setRegion:"), (UInt32)value);
				}
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
		public virtual string Register {
			[Export ("getRegister")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getRegister")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getRegister")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RemoteMode {
			[Export ("remoteMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("remoteMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("remoteMode"));
				}
			}
			
			[Export ("setRemoteMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRemoteMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRemoteMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ReportMode {
			[Export ("reportMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("reportMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reportMode"));
				}
			}
			
			[Export ("setReportMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setReportMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setReportMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Revision {
			[Export ("getRevision")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getRevision")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getRevision")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RssiMode {
			[Export ("rssiMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rssiMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rssiMode"));
				}
			}
			
			[Export ("setRssiMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRssiMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRssiMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int SameReportTime {
			[Export ("sameReportTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("sameReportTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sameReportTime"));
				}
			}
			
			[Export ("setSameReportTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSameReportTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSameReportTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode SaveEpcMask {
			[Export ("saveEpcMask")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("saveEpcMask"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveEpcMask"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode SaveParameter {
			[Export ("saveParameter")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("saveParameter"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("saveParameter"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ScanMode ScanMode {
			[Export ("getScanMode")]
			get {
				if (IsDirectBinding) {
					return (ScanMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("getScanMode"));
				} else {
					return (ScanMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getScanMode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual AsSelectMaskParam SelectionMask {
			[Export ("selectionMask", ArgumentSemantic.Retain)]
			get {
				AsSelectMaskParam ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AsSelectMaskParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectionMask")));
				} else {
					ret =  Runtime.GetNSObject<AsSelectMaskParam> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectionMask")));
				}
				return ret;
			}
			
			[Export ("setSelectionMask:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectionMask:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectionMask:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serialNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serialNumber")));
				}
			}
			
			[Export ("setSerialNumber:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSerialNumber:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSerialNumber:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual SessionFlag SessionFlag {
			[Export ("sessionFlag", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (SessionFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("sessionFlag"));
				} else {
					return (SessionFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionFlag"));
				}
			}
			
			[Export ("setSessionFlag:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setSessionFlag:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setSessionFlag:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int SleepTime {
			[Export ("sleepTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("sleepTime"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sleepTime"));
				}
			}
			
			[Export ("setSleepTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSleepTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSleepTime:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual ResultCode SoftReset {
			[Export ("softReset")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("softReset"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("softReset"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode StartDecode {
			[Export ("startDecode")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("startDecode"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startDecode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode Stop {
			[Export ("stop")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode StopDecode {
			[Export ("stopDecode")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("stopDecode"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopDecode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual ResultCode StopSync {
			[Export ("stopSync")]
			get {
				if (IsDirectBinding) {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("stopSync"));
				} else {
					return (ResultCode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopSync"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StoredCount {
			[Export ("storedCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("storedCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("storedCount"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool StoredMode {
			[Export ("storedMode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("storedMode"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("storedMode"));
				}
			}
			
			[Export ("setStoredMode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setStoredMode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setStoredMode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate Time {
			[Export ("time", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("time")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("time")));
				}
				return ret;
			}
			
			[Export ("setTime:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTime:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTime:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual SelectFlag UseSelectionMask {
			[Export ("useSelectionMask", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (SelectFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("useSelectionMask"));
				} else {
					return (SelectFlag) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useSelectionMask"));
				}
			}
			
			[Export ("setUseSelectionMask:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUseSelectionMask:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUseSelectionMask:"), (UInt32)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual VibratorState Vibrator {
			[Export ("vibrator", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (VibratorState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("vibrator"));
				} else {
					return (VibratorState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vibrator"));
				}
			}
			
			[Export ("setVibrator:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setVibrator:"), (UInt32)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setVibrator:"), (UInt32)value);
				}
			}
		}
		
	} /* class AsReader */
}
