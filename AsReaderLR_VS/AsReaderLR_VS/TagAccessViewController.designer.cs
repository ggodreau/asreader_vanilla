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
	[Register ("TagAccessViewController")]
	partial class TagAccessViewController
	{
		[Outlet]
		UIKit.UISwitch accessPasswordSwitch { get; set; }

		[Outlet]
		UIKit.UIButton[] buttonCollection { get; set; }

		[Outlet]
		UIKit.UIButton clearBtn { get; set; }

		[Outlet]
		UIKit.UISwitch epcSwitch { get; set; }

		[Outlet]
		UIKit.UIButton killBtn { get; set; }

		[Outlet]
		UIKit.UISwitch killPasswordSwitch { get; set; }

		[Outlet]
		UIKit.UIButton lockBtn { get; set; }

		[Outlet]
		UIKit.UIButton maskBtn { get; set; }

		[Outlet]
		UIKit.UILabel messageLabel { get; set; }

		[Outlet]
		UIKit.UITextField operationTimeTextField { get; set; }

		[Outlet]
		UIKit.UITextField passwordTextField { get; set; }

		[Outlet]
		UIKit.UIButton permalockBtn { get; set; }

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
		UIKit.UIButton setAccessPwdBtn { get; set; }

		[Outlet]
		UIKit.UIButton setKillPwdBtn { get; set; }

		[Outlet]
		UIKit.UISwitch tidSwitch { get; set; }

		[Outlet]
		UIKit.UIButton unlockBtn { get; set; }

		[Outlet]
		UIKit.UISwitch userSwitch { get; set; }

		[Action ("clearBtnTapped:")]
		partial void clearBtnTapped (Foundation.NSObject sender);

		[Action ("killBtnTapped:")]
		partial void killBtnTapped (Foundation.NSObject sender);

		[Action ("lockBtnTapped:")]
		partial void lockBtnTapped (Foundation.NSObject sender);

		[Action ("maskBtnTapped:")]
		partial void maskBtnTapped (Foundation.NSObject sender);

		[Action ("operationTimeBtnTapped:")]
		partial void operationTimeBtnTapped (Foundation.NSObject sender);

		[Action ("passwordBtnTapped:")]
		partial void passwordBtnTapped (Foundation.NSObject sender);

		[Action ("permalockBtnTapped:")]
		partial void permalockBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("powerGainBtnTapped:")]
		partial void powerGainBtnTapped (Foundation.NSObject sender);

		[Action ("powerGainPickerOkBtnTapped:")]
		partial void powerGainPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("reportRssiSwitchTapped:")]
		partial void reportRssiSwitchTapped (Foundation.NSObject sender);

		[Action ("setAccessPwdBtnTapped:")]
		partial void setAccessPwdBtnTapped (Foundation.NSObject sender);

		[Action ("setKillPwdBtnTapped:")]
		partial void setKillPwdBtnTapped (Foundation.NSObject sender);

		[Action ("unlockBtnTapped:")]
		partial void unlockBtnTapped (Foundation.NSObject sender);
		
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

			if (killPasswordSwitch != null) {
				killPasswordSwitch.Dispose ();
				killPasswordSwitch = null;
			}

			if (accessPasswordSwitch != null) {
				accessPasswordSwitch.Dispose ();
				accessPasswordSwitch = null;
			}

			if (epcSwitch != null) {
				epcSwitch.Dispose ();
				epcSwitch = null;
			}

			if (tidSwitch != null) {
				tidSwitch.Dispose ();
				tidSwitch = null;
			}

			if (userSwitch != null) {
				userSwitch.Dispose ();
				userSwitch = null;
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

			if (lockBtn != null) {
				lockBtn.Dispose ();
				lockBtn = null;
			}

			if (unlockBtn != null) {
				unlockBtn.Dispose ();
				unlockBtn = null;
			}

			if (permalockBtn != null) {
				permalockBtn.Dispose ();
				permalockBtn = null;
			}

			if (killBtn != null) {
				killBtn.Dispose ();
				killBtn = null;
			}

			if (setAccessPwdBtn != null) {
				setAccessPwdBtn.Dispose ();
				setAccessPwdBtn = null;
			}

			if (setKillPwdBtn != null) {
				setKillPwdBtn.Dispose ();
				setKillPwdBtn = null;
			}

			if (clearBtn != null) {
				clearBtn.Dispose ();
				clearBtn = null;
			}

			if (maskBtn != null) {
				maskBtn.Dispose ();
				maskBtn = null;
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
