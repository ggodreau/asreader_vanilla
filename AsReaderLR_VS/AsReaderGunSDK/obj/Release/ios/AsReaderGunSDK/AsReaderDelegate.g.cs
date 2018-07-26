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
	[Protocol (Name = "AsReaderDelegate", WrapperType = typeof (AsReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderInitialized", Selector = "readerInitialized:", ParameterType = new Type [] { typeof (AsReaderGunSDK.AsReader) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateDeviceState", Selector = "updateDeviceState:", ParameterType = new Type [] { typeof (AsReaderGunSDK.ResultCode) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadTag", Selector = "readTag:rssi:phase:frequency:", ParameterType = new Type [] { typeof (string), typeof (float), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangedActionState", Selector = "changedActionState:resultCode:", ParameterType = new Type [] { typeof (AsReaderGunSDK.CommandType), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DetectBarcode", Selector = "detectBarcode:codeId:barcode:", ParameterType = new Type [] { typeof (AsReaderGunSDK.BarcodeType), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DetectBarcode", Selector = "detectBarcode:codeId:barcodeData:", ParameterType = new Type [] { typeof (AsReaderGunSDK.BarcodeType), typeof (string), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AccessResult", Selector = "accessResult:actionState:epc:data:rssi:phase:", ParameterType = new Type [] { typeof (AsReaderGunSDK.ResultCode), typeof (AsReaderGunSDK.CommandType), typeof (string), typeof (string), typeof (float), typeof (float) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CommandComplete", Selector = "commandComplete:", ParameterType = new Type [] { typeof (AsReaderGunSDK.CommandType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAsReaderLeftModeKeyEvent", Selector = "onAsReaderLeftModeKeyEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAsReaderRightModeKeyEvent", Selector = "onAsReaderRightModeKeyEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAsReaderTriggerKeyEvent", Selector = "onAsReaderTriggerKeyEvent:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface IAsReaderDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class AsReaderDelegate_Extensions {
		[CompilerGenerated]
		public static void ReaderInitialized (this IAsReaderDelegate This, AsReader reader)
		{
			if (reader == null)
				throw new ArgumentNullException ("reader");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("readerInitialized:"), reader.Handle);
		}
		
		[CompilerGenerated]
		public static void UpdateDeviceState (this IAsReaderDelegate This, ResultCode error)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("updateDeviceState:"), (UInt32)error);
		}
		
		[CompilerGenerated]
		public static void ReadTag (this IAsReaderDelegate This, string tag, float rssi, float phase, float frequency)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstag = NSString.CreateNative (tag);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_float_float_float (This.Handle, Selector.GetHandle ("readTag:rssi:phase:frequency:"), nstag, rssi, phase, frequency);
			NSString.ReleaseNative (nstag);
			
		}
		
		[CompilerGenerated]
		public static void ChangedActionState (this IAsReaderDelegate This, CommandType action, nint resultCode)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_nint (This.Handle, Selector.GetHandle ("changedActionState:resultCode:"), (UInt32)action, resultCode);
		}
		
		[CompilerGenerated]
		public static void DetectBarcode (this IAsReaderDelegate This, BarcodeType barcodeType, string codeId, string barcode)
		{
			if (codeId == null)
				throw new ArgumentNullException ("codeId");
			if (barcode == null)
				throw new ArgumentNullException ("barcode");
			var nscodeId = NSString.CreateNative (codeId);
			var nsbarcode = NSString.CreateNative (barcode);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("detectBarcode:codeId:barcode:"), (UInt32)barcodeType, nscodeId, nsbarcode);
			NSString.ReleaseNative (nscodeId);
			NSString.ReleaseNative (nsbarcode);
			
		}
		
		[CompilerGenerated]
		public static void DetectBarcode (this IAsReaderDelegate This, BarcodeType barcodeType, string codeId, NSData barcodeData)
		{
			if (codeId == null)
				throw new ArgumentNullException ("codeId");
			if (barcodeData == null)
				throw new ArgumentNullException ("barcodeData");
			var nscodeId = NSString.CreateNative (codeId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("detectBarcode:codeId:barcodeData:"), (UInt32)barcodeType, nscodeId, barcodeData.Handle);
			NSString.ReleaseNative (nscodeId);
			
		}
		
		[CompilerGenerated]
		public static void AccessResult (this IAsReaderDelegate This, ResultCode error, CommandType action, string epc, string data, float rssi, float phase)
		{
			if (epc == null)
				throw new ArgumentNullException ("epc");
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsepc = NSString.CreateNative (epc);
			var nsdata = NSString.CreateNative (data);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr_IntPtr_float_float (This.Handle, Selector.GetHandle ("accessResult:actionState:epc:data:rssi:phase:"), (UInt32)error, (UInt32)action, nsepc, nsdata, rssi, phase);
			NSString.ReleaseNative (nsepc);
			NSString.ReleaseNative (nsdata);
			
		}
		
		[CompilerGenerated]
		public static void CommandComplete (this IAsReaderDelegate This, CommandType command)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("commandComplete:"), (UInt32)command);
		}
		
		[CompilerGenerated]
		public static bool OnAsReaderLeftModeKeyEvent (this IAsReaderDelegate This, bool status)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onAsReaderLeftModeKeyEvent:"), status);
		}
		
		[CompilerGenerated]
		public static bool OnAsReaderRightModeKeyEvent (this IAsReaderDelegate This, bool status)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onAsReaderRightModeKeyEvent:"), status);
		}
		
		[CompilerGenerated]
		public static bool OnAsReaderTriggerKeyEvent (this IAsReaderDelegate This, bool status)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onAsReaderTriggerKeyEvent:"), status);
		}
		
	}
	
	internal sealed class AsReaderDelegateWrapper : BaseWrapper, IAsReaderDelegate {
		[Preserve (Conditional = true)]
		public AsReaderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace AsReaderGunSDK {
	[Protocol]
	[Register("AsReaderDelegate", false)]
	[Model]
	public unsafe partial class AsReaderDelegate : NSObject, IAsReaderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected AsReaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsReaderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("accessResult:actionState:epc:data:rssi:phase:")]
		[CompilerGenerated]
		public virtual void AccessResult (ResultCode error, CommandType action, string epc, string data, float rssi, float phase)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("changedActionState:resultCode:")]
		[CompilerGenerated]
		public virtual void ChangedActionState (CommandType action, nint resultCode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("commandComplete:")]
		[CompilerGenerated]
		public virtual void CommandComplete (CommandType command)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("detectBarcode:codeId:barcode:")]
		[CompilerGenerated]
		public virtual void DetectBarcode (BarcodeType barcodeType, string codeId, string barcode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("detectBarcode:codeId:barcodeData:")]
		[CompilerGenerated]
		public virtual void DetectBarcode (BarcodeType barcodeType, string codeId, NSData barcodeData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAsReaderLeftModeKeyEvent:")]
		[CompilerGenerated]
		public virtual bool OnAsReaderLeftModeKeyEvent (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAsReaderRightModeKeyEvent:")]
		[CompilerGenerated]
		public virtual bool OnAsReaderRightModeKeyEvent (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onAsReaderTriggerKeyEvent:")]
		[CompilerGenerated]
		public virtual bool OnAsReaderTriggerKeyEvent (bool status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readTag:rssi:phase:frequency:")]
		[CompilerGenerated]
		public virtual void ReadTag (string tag, float rssi, float phase, float frequency)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerInitialized:")]
		[CompilerGenerated]
		public virtual void ReaderInitialized (AsReader reader)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("updateDeviceState:")]
		[CompilerGenerated]
		public virtual void UpdateDeviceState (ResultCode error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class AsReaderDelegate */
}
