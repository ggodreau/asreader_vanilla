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
	[Protocol (Name = "AsReaderGUNReadDataDelegate", WrapperType = typeof (AsReaderGUNReadDataDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadData", Selector = "readData:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	public interface IAsReaderGUNReadDataDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("readData:")]
		[Preserve (Conditional = true)]
		void ReadData (NSData data);
		
	}
	
	internal sealed class AsReaderGUNReadDataDelegateWrapper : BaseWrapper, IAsReaderGUNReadDataDelegate {
		[Preserve (Conditional = true)]
		public AsReaderGUNReadDataDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("readData:")]
		[CompilerGenerated]
		public void ReadData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("readData:"), data.Handle);
		}
		
	}
}
namespace AsReaderGunSDK {
	[Protocol]
	[Register("AsReaderGUNReadDataDelegate", false)]
	[Model]
	public unsafe abstract partial class AsReaderGUNReadDataDelegate : NSObject, IAsReaderGUNReadDataDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AsReaderGUNReadDataDelegate () : base (NSObjectFlag.Empty)
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
		protected AsReaderGUNReadDataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsReaderGUNReadDataDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("readData:")]
		[CompilerGenerated]
		public abstract void ReadData (NSData data);
	} /* class AsReaderGUNReadDataDelegate */
}
