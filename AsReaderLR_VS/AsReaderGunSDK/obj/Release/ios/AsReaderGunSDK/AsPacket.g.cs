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
	[Register("AsPacket", true)]
	public unsafe partial class AsPacket : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsPacket");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsPacket () : base (NSObjectFlag.Empty)
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
		protected AsPacket (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsPacket (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPacketType:subType:")]
		[CompilerGenerated]
		public AsPacket (PacketType type, byte subType)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_byte (this.Handle, Selector.GetHandle ("initWithPacketType:subType:"), (UInt32)type, subType), "initWithPacketType:subType:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_byte (this.SuperHandle, Selector.GetHandle ("initWithPacketType:subType:"), (UInt32)type, subType), "initWithPacketType:subType:");
			}
		}
		
		[Export ("checkTimeoutInterval:withTimeout:")]
		[CompilerGenerated]
		public virtual bool CheckTimeoutInterval (int interval, int maxTimeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("checkTimeoutInterval:withTimeout:"), interval, maxTimeout);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("checkTimeoutInterval:withTimeout:"), interval, maxTimeout);
			}
		}
		
		[Export ("equalPacket:subType:")]
		[CompilerGenerated]
		public virtual bool EqualPacket (PacketType type, byte subType)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32_byte (this.Handle, Selector.GetHandle ("equalPacket:subType:"), (UInt32)type, subType);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_byte (this.SuperHandle, Selector.GetHandle ("equalPacket:subType:"), (UInt32)type, subType);
			}
		}
		
		[Export ("signal")]
		[CompilerGenerated]
		public virtual void Signal ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("signal"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signal"));
			}
		}
		
		[Export ("wait")]
		[CompilerGenerated]
		public virtual void Wait ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("wait"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("wait"));
			}
		}
		
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("data")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data")));
				}
				return ret;
			}
			
			[Export ("setData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setData:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setData:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nint ErrorCode {
			[Export ("errorCode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("errorCode"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("errorCode"));
				}
			}
			
			[Export ("setErrorCode:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setErrorCode:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setErrorCode:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual byte SubType {
			[Export ("subType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("subType"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual PacketType Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return (PacketType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					return (PacketType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
			}
			
		}
		
	} /* class AsPacket */
}
