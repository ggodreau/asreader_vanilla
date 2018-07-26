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
	[Register("AsPacketManager", true)]
	public unsafe partial class AsPacketManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsPacketManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsPacketManager () : base (NSObjectFlag.Empty)
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
		protected AsPacketManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsPacketManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addPacket:")]
		[CompilerGenerated]
		public virtual void AddPacket (AsPacket packet)
		{
			if (packet == null)
				throw new ArgumentNullException ("packet");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addPacket:"), packet.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addPacket:"), packet.Handle);
			}
		}
		
		[Export ("findPacket:subType:")]
		[CompilerGenerated]
		public virtual AsPacket FindPacket (PacketType type, byte subType)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_byte (this.Handle, Selector.GetHandle ("findPacket:subType:"), (UInt32)type, subType));
			} else {
				return  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_byte (this.SuperHandle, Selector.GetHandle ("findPacket:subType:"), (UInt32)type, subType));
			}
		}
		
		[Export ("removePacket:")]
		[CompilerGenerated]
		public virtual void RemovePacket (AsPacket packet)
		{
			if (packet == null)
				throw new ArgumentNullException ("packet");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePacket:"), packet.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePacket:"), packet.Handle);
			}
		}
		
		[Export ("waitPacket:subType:")]
		[CompilerGenerated]
		public virtual AsPacket WaitPacket (PacketType type, byte subType)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_byte (this.Handle, Selector.GetHandle ("waitPacket:subType:"), (UInt32)type, subType));
			} else {
				return  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32_byte (this.SuperHandle, Selector.GetHandle ("waitPacket:subType:"), (UInt32)type, subType));
			}
		}
		
		[CompilerGenerated]
		public virtual AsPacket FirstPacket {
			[Export ("firstPacket")]
			get {
				AsPacket ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstPacket")));
				} else {
					ret =  Runtime.GetNSObject<AsPacket> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstPacket")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsWaitPacket {
			[Export ("isWaitPacket")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWaitPacket"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isWaitPacket"));
				}
			}
			
		}
		
	} /* class AsPacketManager */
}
