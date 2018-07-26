// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AsReaderLR_VS
{
    [Register ("InventoryViewController")]
    partial class InventoryViewController
    {
        [Outlet]
        UIKit.UISwitch continuousModeSwitch { get; set; }


        [Outlet]
        UIKit.UIBarButtonItem csvOutputBtn { get; set; }


        [Outlet]
        UIKit.UISwitch displayPcSwitch { get; set; }


        [Outlet]
        UIKit.UIButton inventoryBtn { get; set; }


        [Outlet]
        UIKit.UITextField inventorySessionTextField { get; set; }


        [Outlet]
        UIKit.UITextField operationTimeTextField { get; set; }


        [Outlet]
        UIKit.UIButton OptionButton { get; set; }


        [Outlet]
        UIKit.UIPickerView pickerView { get; set; }


        [Outlet]
        UIKit.UIView powerGainPickerTopView { get; set; }


        [Outlet]
        UIKit.UITextField powerGainTextField { get; set; }


        [Outlet]
        UIKit.UISwitch reportRssiSwitch { get; set; }


        [Outlet]
        UIKit.UIScrollView scrollView { get; set; }


        [Outlet]
        UIKit.UITextField sessionFlagTextField { get; set; }


        [Outlet]
        UIKit.UILabel speedLabel { get; set; }


        [Outlet]
        UIKit.UITableView tableView { get; set; }


        [Outlet]
        UIKit.UILabel tagCountLabel { get; set; }


        [Outlet]
        UIKit.UIControl [] toDisableElems { get; set; }


        [Outlet]
        UIKit.UILabel totalTagCountLabel { get; set; }

        [Action ("clearBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void clearBtnTapped (UIKit.UIButton sender);

        [Action ("csvOutputBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void csvOutputBtnTapped (UIKit.UIBarButtonItem sender);

        [Action ("inventoryBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void inventoryBtnTapped (UIKit.UIButton sender);

        [Action ("maskBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void maskBtnTapped (UIKit.UIButton sender);

        [Action ("onClickInventorySessionButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onClickInventorySessionButton (UIKit.UIButton sender);

        [Action ("onClickOptionButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onClickOptionButton (UIKit.UIButton sender);

        [Action ("onClickSessionFlagButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onClickSessionFlagButton (UIKit.UIButton sender);

        [Action ("operationTimeBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void operationTimeBtnTapped (UIKit.UIButton sender);

        [Action ("pickerCloseBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void pickerCloseBtnTapped (UIKit.UIButton sender);

        [Action ("powerGainBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void powerGainBtnTapped (UIKit.UIButton sender);

        [Action ("powerGainPickerOkBtnTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void powerGainPickerOkBtnTapped (UIKit.UIButton sender);

        [Action ("powerTextLabelTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void powerTextLabelTapped (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (continuousModeSwitch != null) {
                continuousModeSwitch.Dispose ();
                continuousModeSwitch = null;
            }

            if (csvOutputBtn != null) {
                csvOutputBtn.Dispose ();
                csvOutputBtn = null;
            }

            if (displayPcSwitch != null) {
                displayPcSwitch.Dispose ();
                displayPcSwitch = null;
            }

            if (inventoryBtn != null) {
                inventoryBtn.Dispose ();
                inventoryBtn = null;
            }

            if (inventorySessionTextField != null) {
                inventorySessionTextField.Dispose ();
                inventorySessionTextField = null;
            }

            if (operationTimeTextField != null) {
                operationTimeTextField.Dispose ();
                operationTimeTextField = null;
            }

            if (OptionButton != null) {
                OptionButton.Dispose ();
                OptionButton = null;
            }

            if (pickerView != null) {
                pickerView.Dispose ();
                pickerView = null;
            }

            if (powerGainPickerTopView != null) {
                powerGainPickerTopView.Dispose ();
                powerGainPickerTopView = null;
            }

            if (powerGainTextField != null) {
                powerGainTextField.Dispose ();
                powerGainTextField = null;
            }

            if (reportRssiSwitch != null) {
                reportRssiSwitch.Dispose ();
                reportRssiSwitch = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }

            if (sessionFlagTextField != null) {
                sessionFlagTextField.Dispose ();
                sessionFlagTextField = null;
            }

            if (speedLabel != null) {
                speedLabel.Dispose ();
                speedLabel = null;
            }

            if (tableView != null) {
                tableView.Dispose ();
                tableView = null;
            }

            if (tagCountLabel != null) {
                tagCountLabel.Dispose ();
                tagCountLabel = null;
            }

            if (totalTagCountLabel != null) {
                totalTagCountLabel.Dispose ();
                totalTagCountLabel = null;
            }
        }
    }
}