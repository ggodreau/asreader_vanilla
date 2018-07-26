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
	[Register("Device", true)]
	public unsafe partial class Device : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Device");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Device () : base (NSObjectFlag.Empty)
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
		protected Device (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Device (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithdeviceModel:DeviceAddress:SDK:")]
		[CompilerGenerated]
		public Device (string deviceModel, string deviceAddress, AsRingAccessoryBaseSDK deviceSDK)
			: base (NSObjectFlag.Empty)
		{
			if (deviceModel == null)
				throw new ArgumentNullException ("deviceModel");
			if (deviceAddress == null)
				throw new ArgumentNullException ("deviceAddress");
			if (deviceSDK == null)
				throw new ArgumentNullException ("deviceSDK");
			var nsdeviceModel = NSString.CreateNative (deviceModel);
			var nsdeviceAddress = NSString.CreateNative (deviceAddress);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithdeviceModel:DeviceAddress:SDK:"), nsdeviceModel, nsdeviceAddress, deviceSDK.Handle), "initWithdeviceModel:DeviceAddress:SDK:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithdeviceModel:DeviceAddress:SDK:"), nsdeviceModel, nsdeviceAddress, deviceSDK.Handle), "initWithdeviceModel:DeviceAddress:SDK:");
			}
			NSString.ReleaseNative (nsdeviceModel);
			NSString.ReleaseNative (nsdeviceAddress);
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceAddress {
			[Export ("deviceAddress", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceAddress")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceAddress")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceModel {
			[Export ("deviceModel", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceModel")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceModel")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual AsRingAccessoryBaseSDK DeviceSDK {
			[Export ("deviceSDK", ArgumentSemantic.Retain)]
			get {
				AsRingAccessoryBaseSDK ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AsRingAccessoryBaseSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceSDK")));
				} else {
					ret =  Runtime.GetNSObject<AsRingAccessoryBaseSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceSDK")));
				}
				return ret;
			}
			
		}
		
	} /* class Device */
}
