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
	[Register ("SelectionMaskViewController")]
	partial class SelectionMaskViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem addBarButtonItem { get; set; }

		[Outlet]
		UIKit.UIButton cancelBtn { get; set; }

		[Outlet]
		UIKit.UIView inventorySessionPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField inventorySessionTextField { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIButton saveBtn { get; set; }

		[Outlet]
		UIKit.UIView selectFlagPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField selectFlagTextField { get; set; }

		[Outlet]
		UIKit.UIView sessionFlagPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField sessionFlagTextField { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Action ("inventorySessionBtnTapped:")]
		partial void inventorySessionBtnTapped (Foundation.NSObject sender);

		[Action ("inventorySessionPickerOkBtnTapped:")]
		partial void inventorySessionPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("prepareForUnwind:")]
		partial void prepareForUnwind (UIKit.UIStoryboardSegue segue);

		[Action ("saveBtnTapped:")]
		partial void saveBtnTapped (Foundation.NSObject sender);

		[Action ("selectFlagBtnTapped:")]
		partial void selectFlagBtnTapped (Foundation.NSObject sender);

		[Action ("selectFlagPickerOkBtnTapped:")]
		partial void selectFlagPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("sessionFlagBtnTapped:")]
		partial void sessionFlagBtnTapped (Foundation.NSObject sender);

		[Action ("sessionFlagPickerOkBtnTapped:")]
		partial void sessionFlagPickerOkBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (selectFlagTextField != null) {
				selectFlagTextField.Dispose ();
				selectFlagTextField = null;
			}

			if (inventorySessionTextField != null) {
				inventorySessionTextField.Dispose ();
				inventorySessionTextField = null;
			}

			if (sessionFlagTextField != null) {
				sessionFlagTextField.Dispose ();
				sessionFlagTextField = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (saveBtn != null) {
				saveBtn.Dispose ();
				saveBtn = null;
			}

			if (cancelBtn != null) {
				cancelBtn.Dispose ();
				cancelBtn = null;
			}

			if (selectFlagPickerTopView != null) {
				selectFlagPickerTopView.Dispose ();
				selectFlagPickerTopView = null;
			}

			if (inventorySessionPickerTopView != null) {
				inventorySessionPickerTopView.Dispose ();
				inventorySessionPickerTopView = null;
			}

			if (sessionFlagPickerTopView != null) {
				sessionFlagPickerTopView.Dispose ();
				sessionFlagPickerTopView = null;
			}

			if (addBarButtonItem != null) {
				addBarButtonItem.Dispose ();
				addBarButtonItem = null;
			}
		}
	}
}
