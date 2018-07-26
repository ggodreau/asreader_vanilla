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
	[Register ("ReadMemoryViewController")]
	partial class ReadMemoryViewController
	{
		[Outlet]
		UIKit.UILabel address1Label { get; set; }

		[Outlet]
		UIKit.UILabel address2Label { get; set; }

		[Outlet]
		UIKit.UILabel address3Label { get; set; }

		[Outlet]
		UIKit.UILabel address4Label { get; set; }

		[Outlet]
		UIKit.UILabel address5Label { get; set; }

		[Outlet]
		UIKit.UILabel address6Label { get; set; }

		[Outlet]
		UIKit.UILabel address7Label { get; set; }

		[Outlet]
		UIKit.UILabel address8Label { get; set; }

		[Outlet]
		UIKit.UIView bankPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField bankTextField { get; set; }

		[Outlet]
		UIKit.UIButton blockEraseBtn { get; set; }

		[Outlet]
		UIKit.UIButton clearBtn { get; set; }

		[Outlet]
		UIKit.UIView lengthPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField lengthTextField { get; set; }

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
		UIKit.UIButton readBtn { get; set; }

		[Outlet]
		UIKit.UILabel[] reportRssiCollection { get; set; }

		[Outlet]
		UIKit.UISwitch reportRssiSwitch { get; set; }

		[Outlet]
		UIKit.UILabel rssiLabel { get; set; }

		[Outlet]
		UIKit.UILabel selectionTagLabel { get; set; }

		[Outlet]
		UIKit.UILabel value1Label { get; set; }

		[Outlet]
		UIKit.UILabel value2Label { get; set; }

		[Outlet]
		UIKit.UILabel value3Label { get; set; }

		[Outlet]
		UIKit.UILabel value4Label { get; set; }

		[Outlet]
		UIKit.UILabel value5Label { get; set; }

		[Outlet]
		UIKit.UILabel value6Label { get; set; }

		[Outlet]
		UIKit.UILabel value7Label { get; set; }

		[Outlet]
		UIKit.UILabel value8Label { get; set; }

		[Action ("bankBtnTapped:")]
		partial void bankBtnTapped (Foundation.NSObject sender);

		[Action ("bankPickerOkBtnTapped:")]
		partial void bankPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("blockEraseBtnTapped:")]
		partial void blockEraseBtnTapped (Foundation.NSObject sender);

		[Action ("clearBtnTapped:")]
		partial void clearBtnTapped (Foundation.NSObject sender);

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

		[Action ("prepareForUnwind:")]
		partial void prepareForUnwind (UIKit.UIStoryboardSegue segue);

		[Action ("readBtnTapped:")]
		partial void readBtnTapped (Foundation.NSObject sender);

		[Action ("reportRssiSwitchTapped:")]
		partial void reportRssiSwitchTapped (Foundation.NSObject sender);
		
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

			if (address1Label != null) {
				address1Label.Dispose ();
				address1Label = null;
			}

			if (address2Label != null) {
				address2Label.Dispose ();
				address2Label = null;
			}

			if (address3Label != null) {
				address3Label.Dispose ();
				address3Label = null;
			}

			if (address4Label != null) {
				address4Label.Dispose ();
				address4Label = null;
			}

			if (address5Label != null) {
				address5Label.Dispose ();
				address5Label = null;
			}

			if (address6Label != null) {
				address6Label.Dispose ();
				address6Label = null;
			}

			if (address7Label != null) {
				address7Label.Dispose ();
				address7Label = null;
			}

			if (address8Label != null) {
				address8Label.Dispose ();
				address8Label = null;
			}

			if (value1Label != null) {
				value1Label.Dispose ();
				value1Label = null;
			}

			if (value2Label != null) {
				value2Label.Dispose ();
				value2Label = null;
			}

			if (value3Label != null) {
				value3Label.Dispose ();
				value3Label = null;
			}

			if (value4Label != null) {
				value4Label.Dispose ();
				value4Label = null;
			}

			if (value5Label != null) {
				value5Label.Dispose ();
				value5Label = null;
			}

			if (value6Label != null) {
				value6Label.Dispose ();
				value6Label = null;
			}

			if (value7Label != null) {
				value7Label.Dispose ();
				value7Label = null;
			}

			if (value8Label != null) {
				value8Label.Dispose ();
				value8Label = null;
			}

			if (bankTextField != null) {
				bankTextField.Dispose ();
				bankTextField = null;
			}

			if (offsetTextField != null) {
				offsetTextField.Dispose ();
				offsetTextField = null;
			}

			if (lengthTextField != null) {
				lengthTextField.Dispose ();
				lengthTextField = null;
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

			if (readBtn != null) {
				readBtn.Dispose ();
				readBtn = null;
			}

			if (blockEraseBtn != null) {
				blockEraseBtn.Dispose ();
				blockEraseBtn = null;
			}

			if (clearBtn != null) {
				clearBtn.Dispose ();
				clearBtn = null;
			}

			if (maskBtn != null) {
				maskBtn.Dispose ();
				maskBtn = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
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
		}
	}
}
