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
	[Register ("EpcMaskViewController")]
	partial class EpcMaskViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem addBarButtonItem { get; set; }

		[Outlet]
		UIKit.UIButton cancelBtn { get; set; }

		[Outlet]
		UIKit.UISwitch matchModeSwitch { get; set; }

		[Outlet]
		UIKit.UIButton saveBtn { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("prepareForUnwind:")]
		partial void prepareForUnwind (UIKit.UIStoryboardSegue segue);

		[Action ("saveBtnTapped:")]
		partial void saveBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (saveBtn != null) {
				saveBtn.Dispose ();
				saveBtn = null;
			}

			if (cancelBtn != null) {
				cancelBtn.Dispose ();
				cancelBtn = null;
			}

			if (addBarButtonItem != null) {
				addBarButtonItem.Dispose ();
				addBarButtonItem = null;
			}

			if (matchModeSwitch != null) {
				matchModeSwitch.Dispose ();
				matchModeSwitch = null;
			}
		}
	}
}
