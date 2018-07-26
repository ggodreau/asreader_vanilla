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
	[Register ("WriteMemoryViewController")]
	partial class WriteMemoryViewController
	{
		[Outlet]
		UIKit.UIView bankPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField bankTextField { get; set; }

		[Outlet]
		UIKit.UIButton maskBtn { get; set; }

		[Outlet]
		UIKit.UILabel messageLabel { get; set; }

		[Outlet]
		UIKit.UIView offsetPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField offsetTextField { get; set; }

		[Outlet]
		UIKit.UITextField operationTimeTextField { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UILabel phaseLabel { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIView powerGainPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField powerGainTextField { get; set; }

		[Outlet]
		UIKit.UILabel[] reportRssiCollection { get; set; }

		[Outlet]
		UIKit.UISwitch reportRssiSwitch { get; set; }

		[Outlet]
		UIKit.UILabel rssiLabel { get; set; }

		[Outlet]
		UIKit.UILabel selectionTagLabel { get; set; }

		[Outlet]
		UIKit.UITextField writeDataTextField { get; set; }

		[Action ("bankBtnTapped:")]
		partial void bankBtnTapped (Foundation.NSObject sender);

		[Action ("bankPickerOkBtnTapped:")]
		partial void bankPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("blockWriteBtnTapped:")]
		partial void blockWriteBtnTapped (Foundation.NSObject sender);

		[Action ("clearBtnTapped:")]
		partial void clearBtnTapped (Foundation.NSObject sender);

		[Action ("maskBtnTapped:")]
		partial void maskBtnTapped (Foundation.NSObject sender);

		[Action ("offsetBtnTapped:")]
		partial void offsetBtnTapped (Foundation.NSObject sender);

		[Action ("offsetPickerOkBtnTapped:")]
		partial void offsetPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("operationTimeBtnTapped:")]
		partial void operationTimeBtnTapped (Foundation.NSObject sender);

		[Action ("passwordBtnTapped:")]
		partial void passwordBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("powerGainBtnTapped:")]
		partial void powerGainBtnTapped (Foundation.NSObject sender);

		[Action ("powerGainPickerOkBtnTapped:")]
		partial void powerGainPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("reportRssiSwitchTapped:")]
		partial void reportRssiSwitchTapped (Foundation.NSObject sender);

		[Action ("writeBtnTapped:")]
		partial void writeBtnTapped (Foundation.NSObject sender);

		[Action ("writeDataBtnTapped:")]
		partial void writeDataBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (selectionTagLabel != null) {
				selectionTagLabel.Dispose ();
				selectionTagLabel = null;
			}

			if (messageLabel != null) {
				messageLabel.Dispose ();
				messageLabel = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (bankTextField != null) {
				bankTextField.Dispose ();
				bankTextField = null;
			}

			if (offsetTextField != null) {
				offsetTextField.Dispose ();
				offsetTextField = null;
			}

			if (writeDataTextField != null) {
				writeDataTextField.Dispose ();
				writeDataTextField = null;
			}

			if (passwordTextField != null) {
				passwordTextField.Dispose ();
				passwordTextField = null;
			}

			if (powerGainTextField != null) {
				powerGainTextField.Dispose ();
				powerGainTextField = null;
			}

			if (operationTimeTextField != null) {
				operationTimeTextField.Dispose ();
				operationTimeTextField = null;
			}

			if (bankPickerTopView != null) {
				bankPickerTopView.Dispose ();
				bankPickerTopView = null;
			}

			if (offsetPickerTopView != null) {
				offsetPickerTopView.Dispose ();
				offsetPickerTopView = null;
			}

			if (powerGainPickerTopView != null) {
				powerGainPickerTopView.Dispose ();
				powerGainPickerTopView = null;
			}

			if (rssiLabel != null) {
				rssiLabel.Dispose ();
				rssiLabel = null;
			}

			if (phaseLabel != null) {
				phaseLabel.Dispose ();
				phaseLabel = null;
			}

			if (reportRssiSwitch != null) {
				reportRssiSwitch.Dispose ();
				reportRssiSwitch = null;
			}

			if (maskBtn != null) {
				maskBtn.Dispose ();
				maskBtn = null;
			}
		}
	}
}
