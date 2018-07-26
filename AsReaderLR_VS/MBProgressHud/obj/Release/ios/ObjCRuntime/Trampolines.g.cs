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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::MBProgressHud.MBProgressHUDCompletionBlock))]
		internal delegate void DMBProgressHUDCompletionBlock (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMBProgressHUDCompletionBlock {
			static internal readonly DMBProgressHUDCompletionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMBProgressHUDCompletionBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::MBProgressHud.MBProgressHUDCompletionBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDMBProgressHUDCompletionBlock */
		
		internal class NIDMBProgressHUDCompletionBlock {
			IntPtr blockPtr;
			DMBProgressHUDCompletionBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMBProgressHUDCompletionBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMBProgressHUDCompletionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMBProgressHUDCompletionBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::MBProgressHud.MBProgressHUDCompletionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::MBProgressHud.MBProgressHUDCompletionBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMBProgressHUDCompletionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDMBProgressHUDCompletionBlock */
	}
}
