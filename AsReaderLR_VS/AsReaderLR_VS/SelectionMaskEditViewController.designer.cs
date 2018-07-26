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
	[Register ("SelectionMaskEditViewController")]
	partial class SelectionMaskEditViewController
	{
		[Outlet]
		UIKit.UIView actionPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField actionTextField { get; set; }

		[Outlet]
		UIKit.UIView bankPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField bankTextField { get; set; }

		[Outlet]
		UIKit.UIView lengthPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField lengthTextField { get; set; }

		[Outlet]
		UIKit.UITextField maskTextField { get; set; }

		[Outlet]
		UIKit.UIView offsetPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField offsetTextField { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIView targetPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField targetTextField { get; set; }

		[Action ("actionBtnTapped:")]
		partial void actionBtnTapped (Foundation.NSObject sender);

		[Action ("actionPickerOkBtnTapped:")]
		partial void actionPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("bankBtnTapped:")]
		partial void bankBtnTapped (Foundation.NSObject sender);

		[Action ("bankPickerOkBtnTapped:")]
		partial void bankPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("lengthBtnTapped:")]
		partial void lengthBtnTapped (Foundation.NSObject sender);

		[Action ("lengthPickerOkBtnTapped:")]
		partial void lengthPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("maskBtnTapped:")]
		partial void maskBtnTapped (Foundation.NSObject sender);

		[Action ("offsetBtnTapped:")]
		partial void offsetBtnTapped (Foundation.NSObject sender);

		[Action ("offsetPickerOkBtnTapped:")]
		partial void offsetPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("targetBtnTapped:")]
		partial void targetBtnTapped (Foundation.NSObject sender);

		[Action ("targetPickerOkBtnTapped:")]
		partial void targetPickerOkBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (targetTextField != null) {
				targetTextField.Dispose ();
				targetTextField = null;
			}

			if (actionTextField != null) {
				actionTextField.Dispose ();
				actionTextField = null;
			}

			if (bankTextField != null) {
				bankTextField.Dispose ();
				bankTextField = null;
			}

			if (offsetTextField != null) {
				offsetTextField.Dispose ();
				offsetTextField = null;
			}

			if (maskTextField != null) {
				maskTextField.Dispose ();
				maskTextField = null;
			}

			if (lengthTextField != null) {
				lengthTextField.Dispose ();
				lengthTextField = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (targetPickerTopView != null) {
				targetPickerTopView.Dispose ();
				targetPickerTopView = null;
			}

			if (actionPickerTopView != null) {
				actionPickerTopView.Dispose ();
				actionPickerTopView = null;
			}

			if (bankPickerTopView != null) {
				bankPickerTopView.Dispose ();
				bankPickerTopView = null;
			}

			if (offsetPickerTopView != null) {
				offsetPickerTopView.Dispose ();
				offsetPickerTopView = null;
			}

			if (lengthPickerTopView != null) {
				lengthPickerTopView.Dispose ();
				lengthPickerTopView = null;
			}
		}
	}
}
