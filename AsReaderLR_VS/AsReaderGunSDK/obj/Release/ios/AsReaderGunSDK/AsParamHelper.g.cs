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
	[Register("AsParamHelper", true)]
	public unsafe partial class AsParamHelper : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AsParamHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AsParamHelper () : base (NSObjectFlag.Empty)
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
		protected AsParamHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AsParamHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getBytesWithParamName:")]
		[CompilerGenerated]
		public static NSData GetBytesWithParamName (NSNumber paramName)
		{
			if (paramName == null)
				throw new ArgumentNullException ("paramName");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getBytesWithParamName:"), paramName.Handle));
		}
		
		[Export ("getBytesWithParamNames:")]
		[CompilerGenerated]
		public static NSData GetBytesWithParamNames (NSObject[] paramNames)
		{
			if (paramNames == null)
				throw new ArgumentNullException ("paramNames");
			var nsa_paramNames = NSArray.FromNSObjects (paramNames);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getBytesWithParamNames:"), nsa_paramNames.Handle));
			nsa_paramNames.Dispose ();
			
			return ret;
		}
		
		[Export ("getParam:")]
		[CompilerGenerated]
		public static AsParamValue GetParam (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return  Runtime.GetNSObject<AsParamValue> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getParam:"), data.Handle));
		}
		
		[Export ("getParamList:")]
		[CompilerGenerated]
		public static NSObject[] GetParamList (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getParamList:"), data.Handle));
		}
		
		[Export ("setBytesWithParamValue:")]
		[CompilerGenerated]
		public static NSData SetBytesWithParamValue (AsParamValue paramName)
		{
			if (paramName == null)
				throw new ArgumentNullException ("paramName");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setBytesWithParamValue:"), paramName.Handle));
		}
		
	} /* class AsParamHelper */
}
