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
	[Register ("BarcodeDemoViewController")]
	partial class BarcodeDemoViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem outputBtn { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIView rescanTimePickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField rescanTimeTextField { get; set; }

		[Outlet]
		UIKit.UIButton startScanBtn { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.UIControl[] toDisableElems { get; set; }

		[Outlet]
		UIKit.UILabel totalCountLabel { get; set; }

		[Action ("clearBtnTapped:")]
		partial void clearBtnTapped (Foundation.NSObject sender);

		[Action ("outputCSVBtnTapped:")]
		partial void outputCSVBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("rescanTimeBtnTapped:")]
		partial void rescanTimeBtnTapped (Foundation.NSObject sender);

		[Action ("rescanTimePickerOkBtnTapped:")]
		partial void rescanTimePickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("scanStartBtnTapped:")]
		partial void scanStartBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (outputBtn != null) {
				outputBtn.Dispose ();
				outputBtn = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (rescanTimePickerTopView != null) {
				rescanTimePickerTopView.Dispose ();
				rescanTimePickerTopView = null;
			}

			if (rescanTimeTextField != null) {
				rescanTimeTextField.Dispose ();
				rescanTimeTextField = null;
			}

			if (startScanBtn != null) {
				startScanBtn.Dispose ();
				startScanBtn = null;
			}

			if (totalCountLabel != null) {
				totalCountLabel.Dispose ();
				totalCountLabel = null;
			}
		}
	}
}
