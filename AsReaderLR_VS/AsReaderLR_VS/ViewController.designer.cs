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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel asRingPlusVersion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton BarcodeOption { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton BarcodeScan { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView batteryImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buzzerButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField buzzerTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton Inventory { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelBluetoothAddr { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDemoVer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelFirmwareVer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton LockMemory { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView logoImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView mainScrollView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton ReadMemory { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel regionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton RFIDOption { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel snLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ufVersion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton vibratorButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField vibratorTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AsReaderLR_VS.MainButton WriteMemory { get; set; }

        [Action ("onClickBuzzerButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onClickBuzzerButton (UIKit.UIButton sender);

        [Action ("onClickVibratorButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onClickVibratorButton (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (asRingPlusVersion != null) {
                asRingPlusVersion.Dispose ();
                asRingPlusVersion = null;
            }

            if (BarcodeOption != null) {
                BarcodeOption.Dispose ();
                BarcodeOption = null;
            }

            if (BarcodeScan != null) {
                BarcodeScan.Dispose ();
                BarcodeScan = null;
            }

            if (batteryImage != null) {
                batteryImage.Dispose ();
                batteryImage = null;
            }

            if (buzzerButton != null) {
                buzzerButton.Dispose ();
                buzzerButton = null;
            }

            if (buzzerTextField != null) {
                buzzerTextField.Dispose ();
                buzzerTextField = null;
            }

            if (Inventory != null) {
                Inventory.Dispose ();
                Inventory = null;
            }

            if (labelBluetoothAddr != null) {
                labelBluetoothAddr.Dispose ();
                labelBluetoothAddr = null;
            }

            if (labelDemoVer != null) {
                labelDemoVer.Dispose ();
                labelDemoVer = null;
            }

            if (labelFirmwareVer != null) {
                labelFirmwareVer.Dispose ();
                labelFirmwareVer = null;
            }

            if (LockMemory != null) {
                LockMemory.Dispose ();
                LockMemory = null;
            }

            if (logoImage != null) {
                logoImage.Dispose ();
                logoImage = null;
            }

            if (mainScrollView != null) {
                mainScrollView.Dispose ();
                mainScrollView = null;
            }

            if (ReadMemory != null) {
                ReadMemory.Dispose ();
                ReadMemory = null;
            }

            if (regionLabel != null) {
                regionLabel.Dispose ();
                regionLabel = null;
            }

            if (RFIDOption != null) {
                RFIDOption.Dispose ();
                RFIDOption = null;
            }

            if (snLabel != null) {
                snLabel.Dispose ();
                snLabel = null;
            }

            if (ufVersion != null) {
                ufVersion.Dispose ();
                ufVersion = null;
            }

            if (vibratorButton != null) {
                vibratorButton.Dispose ();
                vibratorButton = null;
            }

            if (vibratorTextField != null) {
                vibratorTextField.Dispose ();
                vibratorTextField = null;
            }

            if (WriteMemory != null) {
                WriteMemory.Dispose ();
                WriteMemory = null;
            }
        }
    }
}