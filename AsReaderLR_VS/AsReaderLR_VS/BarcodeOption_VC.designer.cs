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
	[Register ("BarcodeOption_VC")]
	partial class BarcodeOption_VC
	{
		[Outlet]
		UIKit.UITextField batteryIntervalTextField { get; set; }

		[Outlet]
		UIKit.UIView buzzerPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField buzzerTextField { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollView { get; set; }

		[Outlet]
		UIKit.UIView shadowView { get; set; }

		[Outlet]
		UIKit.UITextField sleepTimeTextField { get; set; }

		[Outlet]
		UIKit.UIView vibratorPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField vibratorTextField { get; set; }

		[Action ("batteryIntervalBtnTapped:")]
		partial void batteryIntervalBtnTapped (Foundation.NSObject sender);

		[Action ("buzzerBtnTapped:")]
		partial void buzzerBtnTapped (Foundation.NSObject sender);

		[Action ("buzzerPickerOkBtnTapped:")]
		partial void buzzerPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("defaultBtnTapped:")]
		partial void defaultBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("saveBtnTapped:")]
		partial void saveBtnTapped (Foundation.NSObject sender);

		[Action ("sleepTimeBtnTapped:")]
		partial void sleepTimeBtnTapped (Foundation.NSObject sender);

		[Action ("tableCloseBtnTapped:")]
		partial void tableCloseBtnTapped (Foundation.NSObject sender);

		[Action ("vibratorBtnTapped:")]
		partial void vibratorBtnTapped (Foundation.NSObject sender);

		[Action ("vibratorPickerOkBtnTapped:")]
		partial void vibratorPickerOkBtnTapped (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (buzzerTextField != null) {
				buzzerTextField.Dispose ();
				buzzerTextField = null;
			}

			if (vibratorTextField != null) {
				vibratorTextField.Dispose ();
				vibratorTextField = null;
			}

			if (batteryIntervalTextField != null) {
				batteryIntervalTextField.Dispose ();
				batteryIntervalTextField = null;
			}

			if (buzzerPickerTopView != null) {
				buzzerPickerTopView.Dispose ();
				buzzerPickerTopView = null;
			}

			if (vibratorPickerTopView != null) {
				vibratorPickerTopView.Dispose ();
				vibratorPickerTopView = null;
			}

			if (shadowView != null) {
				shadowView.Dispose ();
				shadowView = null;
			}

			if (sleepTimeTextField != null) {
				sleepTimeTextField.Dispose ();
				sleepTimeTextField = null;
			}
		}
	}
}
