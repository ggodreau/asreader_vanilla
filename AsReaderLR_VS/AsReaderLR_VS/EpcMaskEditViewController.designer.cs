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
	[Register ("EpcMaskEditViewController")]
	partial class EpcMaskEditViewController
	{
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
		
		void ReleaseDesignerOutlets ()
		{
			if (lengthPickerTopView != null) {
				lengthPickerTopView.Dispose ();
				lengthPickerTopView = null;
			}

			if (lengthTextField != null) {
				lengthTextField.Dispose ();
				lengthTextField = null;
			}

			if (maskTextField != null) {
				maskTextField.Dispose ();
				maskTextField = null;
			}

			if (offsetPickerTopView != null) {
				offsetPickerTopView.Dispose ();
				offsetPickerTopView = null;
			}

			if (offsetTextField != null) {
				offsetTextField.Dispose ();
				offsetTextField = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}
		}
	}
}
