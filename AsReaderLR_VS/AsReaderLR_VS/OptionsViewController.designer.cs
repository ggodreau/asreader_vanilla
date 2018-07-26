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
	[Register ("OptionsViewController")]
	partial class OptionsViewController
	{
		[Outlet]
		UIKit.UIView algorithmPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField algorithmTextField { get; set; }

		[Outlet]
		UIKit.UITextField autoOffTimeTextField { get; set; }

		[Outlet]
		UIKit.UITextField batteryIntervalTextField { get; set; }

		[Outlet]
		UIKit.UIView buzzerPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField buzzerTextField { get; set; }

		[Outlet]
		UIKit.UITextField defaultLinkProfileTextField { get; set; }

		[Outlet]
		UIKit.UITextField idleTimeTextField { get; set; }

		[Outlet]
		UIKit.UITextField inventoryTimeTextField { get; set; }

		[Outlet]
		UIKit.UIView keyActionPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField keyActionTextField { get; set; }

		[Outlet]
		UIKit.UIView lbtChannelTableTopView { get; set; }

		[Outlet]
		UIKit.UIView LinkProfileTableTopView { get; set; }

		[Outlet]
		UIKit.UITextField linkProfileTextField { get; set; }

		[Outlet]
		UIKit.UIView maskTypePickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField maskTypeTextField { get; set; }

		[Outlet]
		UIKit.UITextField maxQValueTextField { get; set; }

		[Outlet]
		UIKit.UITextField minQValueTextField { get; set; }

		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }

		[Outlet]
		UIKit.UIView qValuePickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField qValueTextField { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollView { get; set; }

		[Outlet]
		UIKit.UIButton setLBTButton { get; set; }

		[Outlet]
		UIKit.UIView shadowView { get; set; }

		[Outlet]
		UIKit.UITextField sleepTimeTextField { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.UIView vibratorPickerTopView { get; set; }

		[Outlet]
		UIKit.UITextField vibratorTextField { get; set; }

		[Action ("algorithmBtnTapped:")]
		partial void algorithmBtnTapped (Foundation.NSObject sender);

		[Action ("algorithmPickerOkBtnTapped:")]
		partial void algorithmPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("autoOffTimeBtnTapped:")]
		partial void autoOffTimeBtnTapped (Foundation.NSObject sender);

		[Action ("batteryIntervalBtnTapped:")]
		partial void batteryIntervalBtnTapped (Foundation.NSObject sender);

		[Action ("buzzerBtnTapped:")]
		partial void buzzerBtnTapped (Foundation.NSObject sender);

		[Action ("buzzerPickerOkBtnTapped:")]
		partial void buzzerPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("defaultBtnTapped:")]
		partial void defaultBtnTapped (Foundation.NSObject sender);

		[Action ("defaultLinkProfileBtnTapped:")]
		partial void defaultLinkProfileBtnTapped (Foundation.NSObject sender);

		[Action ("idleTimeBtnTapped:")]
		partial void idleTimeBtnTapped (Foundation.NSObject sender);

		[Action ("inventoryTimeBtnTapped:")]
		partial void inventoryTimeBtnTapped (Foundation.NSObject sender);

		[Action ("keyActionBtnTapped:")]
		partial void keyActionBtnTapped (Foundation.NSObject sender);

		[Action ("keyActionPickerOkBtnTapped:")]
		partial void keyActionPickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("lbtChannelBtnTapped:")]
		partial void lbtChannelBtnTapped (Foundation.NSObject sender);

		[Action ("lbtChannelTableOkBtnTapped:")]
		partial void lbtChannelTableOkBtnTapped (Foundation.NSObject sender);

		[Action ("linkProfileBtnTapped:")]
		partial void linkProfileBtnTapped (Foundation.NSObject sender);

		[Action ("linkProfilePickerOkBtnTapped:")]
		partial void linkProfilePickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("maskTypeBtnTapped:")]
		partial void maskTypeBtnTapped (Foundation.NSObject sender);

		[Action ("maskTypePickerOkBtnTapped:")]
		partial void maskTypePickerOkBtnTapped (Foundation.NSObject sender);

		[Action ("maxQValueBtnTapped:")]
		partial void maxQValueBtnTapped (Foundation.NSObject sender);

		[Action ("minQValueBtnTapped:")]
		partial void minQValueBtnTapped (Foundation.NSObject sender);

		[Action ("pickerCloseBtnTapped:")]
		partial void pickerCloseBtnTapped (Foundation.NSObject sender);

		[Action ("qValueBtnTapped:")]
		partial void qValueBtnTapped (Foundation.NSObject sender);

		[Action ("qValuePickerOkBtnTapped:")]
		partial void qValuePickerOkBtnTapped (Foundation.NSObject sender);

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

			if (setLBTButton != null) {
				setLBTButton.Dispose ();
				setLBTButton = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (buzzerTextField != null) {
				buzzerTextField.Dispose ();
				buzzerTextField = null;
			}

			if (vibratorTextField != null) {
				vibratorTextField.Dispose ();
				vibratorTextField = null;
			}

			if (inventoryTimeTextField != null) {
				inventoryTimeTextField.Dispose ();
				inventoryTimeTextField = null;
			}

			if (idleTimeTextField != null) {
				idleTimeTextField.Dispose ();
				idleTimeTextField = null;
			}

			if (autoOffTimeTextField != null) {
				autoOffTimeTextField.Dispose ();
				autoOffTimeTextField = null;
			}

			if (keyActionTextField != null) {
				keyActionTextField.Dispose ();
				keyActionTextField = null;
			}

			if (batteryIntervalTextField != null) {
				batteryIntervalTextField.Dispose ();
				batteryIntervalTextField = null;
			}

			if (maskTypeTextField != null) {
				maskTypeTextField.Dispose ();
				maskTypeTextField = null;
			}

			if (buzzerPickerTopView != null) {
				buzzerPickerTopView.Dispose ();
				buzzerPickerTopView = null;
			}

			if (vibratorPickerTopView != null) {
				vibratorPickerTopView.Dispose ();
				vibratorPickerTopView = null;
			}

			if (keyActionPickerTopView != null) {
				keyActionPickerTopView.Dispose ();
				keyActionPickerTopView = null;
			}

			if (maskTypePickerTopView != null) {
				maskTypePickerTopView.Dispose ();
				maskTypePickerTopView = null;
			}

			if (lbtChannelTableTopView != null) {
				lbtChannelTableTopView.Dispose ();
				lbtChannelTableTopView = null;
			}

			if (shadowView != null) {
				shadowView.Dispose ();
				shadowView = null;
			}

			if (algorithmTextField != null) {
				algorithmTextField.Dispose ();
				algorithmTextField = null;
			}

			if (algorithmPickerTopView != null) {
				algorithmPickerTopView.Dispose ();
				algorithmPickerTopView = null;
			}

			if (qValueTextField != null) {
				qValueTextField.Dispose ();
				qValueTextField = null;
			}

			if (qValuePickerTopView != null) {
				qValuePickerTopView.Dispose ();
				qValuePickerTopView = null;
			}

			if (minQValueTextField != null) {
				minQValueTextField.Dispose ();
				minQValueTextField = null;
			}

			if (maxQValueTextField != null) {
				maxQValueTextField.Dispose ();
				maxQValueTextField = null;
			}

			if (linkProfileTextField != null) {
				linkProfileTextField.Dispose ();
				linkProfileTextField = null;
			}

			if (defaultLinkProfileTextField != null) {
				defaultLinkProfileTextField.Dispose ();
				defaultLinkProfileTextField = null;
			}

			if (sleepTimeTextField != null) {
				sleepTimeTextField.Dispose ();
				sleepTimeTextField = null;
			}

			if (LinkProfileTableTopView != null) {
				LinkProfileTableTopView.Dispose ();
				LinkProfileTableTopView = null;
			}
		}
	}
}
