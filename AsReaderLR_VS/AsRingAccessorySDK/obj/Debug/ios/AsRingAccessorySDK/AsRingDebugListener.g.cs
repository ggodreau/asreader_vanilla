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
	[Protocol (Name = "AsRingDebugListener", WrapperType = typeof (AsRingDebugListenerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WhenReciveDebugData", Selector = "whenReciveDebugData:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WhenSendDebugData", Selector = "whenSendDebugData:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	public interface IAsRingDebugListener : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("whenReciveDebugData:")]
		[Preserve (Conditional = true)]
		void WhenReciveDebugData (NSData data);
		
		[CompilerGenerated]
		[Export ("whenSendDebugData:")]
		[Preserve (Conditional = true)]
		void WhenSendDebugData (NSData data);
		
	}
	
	internal sealed class AsRingDebugListenerWrapper : BaseWrapper, IAsRingDebugListener {
		[Preserve (Conditional = true)]
		public AsRingDebugListenerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("whenReciveDebugData:")]
		[CompilerGenerated]
		public void WhenReciveDebugData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("whenReciveDebugData:"), data.Handle);
		}
		
		[Export ("whenSendDebugData:")]
		[CompilerGenerated]
		public void WhenSendDebugData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("whenSendDebugData:"), data.Handle);
		}
		
	}
}
namespace AsRingAccessorySDK {
	[Protocol]
	[Register("AsRingDebugListener", false)]
	[Model]
	public unsafe abstract partial class AsRingDebugListener : NSObject, IAsRingDebugListener {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AsRingDebugListener () : base (NSObjectFlag.Empty)
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
		protected AsRingDebugListener (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsRingDebugListener (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("whenReciveDebugData:")]
		[CompilerGenerated]
		public abstract void WhenReciveDebugData (NSData data);
		[Export ("whenSendDebugData:")]
		[CompilerGenerated]
		public abstract void WhenSendDebugData (NSData data);
	} /* class AsRingDebugListener */
}
