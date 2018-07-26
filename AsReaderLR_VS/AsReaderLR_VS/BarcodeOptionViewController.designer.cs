// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AsReaderLR_VS
{
	[Register ("BarcodeOptionViewController")]
	partial class BarcodeOptionViewController
	{
		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("defaultAllSymBtnTapped:")]
		partial void defaultAllSymBtnTapped (Foundation.NSObject sender);

		[Action ("disableAllSymBtnTapped:")]
		partial void disableAllSymBtnTapped (Foundation.NSObject sender);

		[Action ("enableAllSymBtnTapped:")]
		partial void enableAllSymBtnTapped (Foundation.NSObject sender);

		[Action ("saveSymBtnTapped:")]
		partial void saveSymBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
