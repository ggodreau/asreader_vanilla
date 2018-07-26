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
	[Protocol (Name = "AsRingDeviceSDKDelegate", WrapperType = typeof (AsRingDeviceSDKDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PluggedAsRing", Selector = "pluggedAsRing:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnAsRingError", Selector = "onAsRingError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AsRingDeviceRx", Selector = "asRingDeviceRx:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AsRingRx", Selector = "asRingRx:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AsRingModeTransition", Selector = "asRingModeTransition:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnFileReceived", Selector = "onFileReceived:", ParameterType = new Type [] { typeof (AsRingAccessorySDK.FileModel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnFloderReceived", Selector = "onFloderReceived:", ParameterType = new Type [] { typeof (AsRingAccessorySDK.FloderModel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnDeviceDebug", Selector = "onDeviceDebug:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface IAsRingDeviceSDKDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("pluggedAsRing:")]
		[Preserve (Conditional = true)]
		void PluggedAsRing (bool plug);
		
		[CompilerGenerated]
		[Export ("onAsRingError:")]
		[Preserve (Conditional = true)]
		void OnAsRingError (NSError error);
		
		[CompilerGenerated]
		[Export ("asRingDeviceRx:")]
		[Preserve (Conditional = true)]
		void AsRingDeviceRx (NSData reciveData);
		
		[CompilerGenerated]
		[Export ("asRingRx:")]
		[Preserve (Conditional = true)]
		void AsRingRx (NSData reciveData);
		
		[CompilerGenerated]
		[Export ("asRingModeTransition:")]
		[Preserve (Conditional = true)]
		void AsRingModeTransition (bool success);
		
		[CompilerGenerated]
		[Export ("onFileReceived:")]
		[Preserve (Conditional = true)]
		void OnFileReceived (FileModel file);
		
		[CompilerGenerated]
		[Export ("onFloderReceived:")]
		[Preserve (Conditional = true)]
		void OnFloderReceived (FloderModel floder);
		
		[CompilerGenerated]
		[Export ("onDeviceDebug:")]
		[Preserve (Conditional = true)]
		void OnDeviceDebug (bool isOpen);
		
	}
	
	internal sealed class AsRingDeviceSDKDelegateWrapper : BaseWrapper, IAsRingDeviceSDKDelegate {
		[Preserve (Conditional = true)]
		public AsRingDeviceSDKDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("pluggedAsRing:")]
		[CompilerGenerated]
		public void PluggedAsRing (bool plug)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("pluggedAsRing:"), plug);
		}
		
		[Export ("onAsRingError:")]
		[CompilerGenerated]
		public void OnAsRingError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onAsRingError:"), error.Handle);
		}
		
		[Export ("asRingDeviceRx:")]
		[CompilerGenerated]
		public void AsRingDeviceRx (NSData reciveData)
		{
			if (reciveData == null)
				throw new ArgumentNullException ("reciveData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("asRingDeviceRx:"), reciveData.Handle);
		}
		
		[Export ("asRingRx:")]
		[CompilerGenerated]
		public void AsRingRx (NSData reciveData)
		{
			if (reciveData == null)
				throw new ArgumentNullException ("reciveData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("asRingRx:"), reciveData.Handle);
		}
		
		[Export ("asRingModeTransition:")]
		[CompilerGenerated]
		public void AsRingModeTransition (bool success)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("asRingModeTransition:"), success);
		}
		
		[Export ("onFileReceived:")]
		[CompilerGenerated]
		public void OnFileReceived (FileModel file)
		{
			if (file == null)
				throw new ArgumentNullException ("file");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onFileReceived:"), file.Handle);
		}
		
		[Export ("onFloderReceived:")]
		[CompilerGenerated]
		public void OnFloderReceived (FloderModel floder)
		{
			if (floder == null)
				throw new ArgumentNullException ("floder");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onFloderReceived:"), floder.Handle);
		}
		
		[Export ("onDeviceDebug:")]
		[CompilerGenerated]
		public void OnDeviceDebug (bool isOpen)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onDeviceDebug:"), isOpen);
		}
		
	}
}
namespace AsRingAccessorySDK {
	[Protocol]
	[Register("AsRingDeviceSDKDelegate", false)]
	[Model]
	public unsafe abstract partial class AsRingDeviceSDKDelegate : NSObject, IAsRingDeviceSDKDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AsRingDeviceSDKDelegate () : base (NSObjectFlag.Empty)
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
		protected AsRingDeviceSDKDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsRingDeviceSDKDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("asRingDeviceRx:")]
		[CompilerGenerated]
		public abstract void AsRingDeviceRx (NSData reciveData);
		[Export ("asRingModeTransition:")]
		[CompilerGenerated]
		public abstract void AsRingModeTransition (bool success);
		[Export ("asRingRx:")]
		[CompilerGenerated]
		public abstract void AsRingRx (NSData reciveData);
		[Export ("onAsRingError:")]
		[CompilerGenerated]
		public abstract void OnAsRingError (NSError error);
		[Export ("onDeviceDebug:")]
		[CompilerGenerated]
		public abstract void OnDeviceDebug (bool isOpen);
		[Export ("onFileReceived:")]
		[CompilerGenerated]
		public abstract void OnFileReceived (FileModel file);
		[Export ("onFloderReceived:")]
		[CompilerGenerated]
		public abstract void OnFloderReceived (FloderModel floder);
		[Export ("pluggedAsRing:")]
		[CompilerGenerated]
		public abstract void PluggedAsRing (bool plug);
	} /* class AsRingDeviceSDKDelegate */
}
