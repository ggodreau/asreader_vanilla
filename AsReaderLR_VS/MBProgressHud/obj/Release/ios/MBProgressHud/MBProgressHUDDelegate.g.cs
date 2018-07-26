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

namespace MBProgressHud {
	[Protocol (Name = "MBProgressHUDDelegate", WrapperType = typeof (MBProgressHUDDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HudWasHidden", Selector = "hudWasHidden:", ParameterType = new Type [] { typeof (MBProgressHud.MBProgressHUD) }, ParameterByRef = new bool [] { false })]
	public interface IMBProgressHUDDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MBProgressHUDDelegate_Extensions {
		[CompilerGenerated]
		public static void HudWasHidden (this IMBProgressHUDDelegate This, MBProgressHUD hud)
		{
			if (hud == null)
				throw new ArgumentNullException ("hud");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hudWasHidden:"), hud.Handle);
		}
		
	}
	
	internal sealed class MBProgressHUDDelegateWrapper : BaseWrapper, IMBProgressHUDDelegate {
		[Preserve (Conditional = true)]
		public MBProgressHUDDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MBProgressHud {
	[Protocol]
	[Register("MBProgressHUDDelegate", false)]
	[Model]
	public unsafe partial class MBProgressHUDDelegate : NSObject, IMBProgressHUDDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MBProgressHUDDelegate () : base (NSObjectFlag.Empty)
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
		protected MBProgressHUDDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MBProgressHUDDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hudWasHidden:")]
		[CompilerGenerated]
		public virtual void HudWasHidden (MBProgressHUD hud)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MBProgressHUDDelegate */
}
