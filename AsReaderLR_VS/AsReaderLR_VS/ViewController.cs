using System;
using UIKit;
using Foundation;
using AsRingAccessorySDK;
using AsReaderGunSDK;
using CoreAnimation;

namespace AsReaderLR_VS
{
    public partial class ViewController : UIViewController
    {
        int BATTERY_NONE =           0;
        int BATTERY_QUARTER =        1;
        int BATTERY_HALF =           2;
        int BATTERY_THIRD_QUARTER =  3;
        int BATTERY_FULL =           4;

        int CONNECTION_OFF =         0;
        int CONNECTION_ON =          1;

        AppDelegate appDelegate;

        UIBarButtonItem searchBarButtonItem;
        UITapGestureRecognizer logoDebugTap;
        AsRingDeviceSDK asRingDeviceSDK;
        UIView backView;
        //NSString updateUrl;

        MainButton[] buttonCollection;

        AsReaderGUNManager gunManager = AsReaderGUNManager.sharedAsReaderGUNManager();

        AsReader mReader{
            get => gunManager.getCurrentAsReader();
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            gunManager.onAsReaderGUNConnected = () => reloadData();

			asRingDeviceSDK = AsRingDeviceSDK.SharedAsRingDeviceSDK;

            buttonCollection = new MainButton[] {Inventory, RFIDOption, ReadMemory, LockMemory, BarcodeScan, BarcodeOption, WriteMemory };
            appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;

            labelDemoVer.Text = appDelegate.getAppVersion();

            regionLabel.Text = "";
            snLabel.Text = "";
            ufVersion.Text = "";

            mainScrollView.ContentSize = new CoreGraphics.CGSize(0, View.Frame.Size.Height);

            mainScrollView.ShowsVerticalScrollIndicator = false;
            searchBarButtonItem = NavigationItem.RightBarButtonItem;

            logoDebugTap = null;

            //VersionHandler-------
            int buzzerTime = SystemSetting.sharedSystemSetting().getBuzzerTime();
            buzzerTextField.Text = buzzerTime.ToString();
            int vibratorTime = SystemSetting.sharedSystemSetting().getVibratorTime();
            vibratorTextField.Text = vibratorTime.ToString();

            buzzerTextField.Delegate = new MyTextFieldDelegate(this);
            vibratorTextField.Delegate = new MyTextFieldDelegate(this);
            backView = new UIView();
            backView.BackgroundColor = UIColor.Gray;
            backView.Alpha = (nfloat)0.5;
            backView.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Size.Width, View.Frame.Size.Height);
            mainScrollView.SetContentOffset(new CoreGraphics.CGPoint(0, 0), true);

            UITapGestureRecognizer tapGestureRecognizer = new UITapGestureRecognizer(keyboardHide);
            tapGestureRecognizer.CancelsTouchesInView = false;
            View.AddGestureRecognizer(tapGestureRecognizer);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        void AccessResult(ResultCode error, CommandType action, string epc, string data, float rssi, float phase)
        {
            //base.AccessResult(error, action, epc, data, rssi, phase);
            if (error != ResultCode.NoError)
            {
                UIAlertView alert = new UIAlertView("Error", AsResultCode.Msg(error), null, "OK", null);
                alert.Show();
            }
        }
        bool OnAsReaderLeftModeKeyEvent(bool status)
        {
            if (mReader.IsRFIDModule && mReader.IsBarcodeModule)
            {
                return true;
            }
            return false;
        }

        bool OnAsReaderRightModeKeyEvent(bool status)
        {
            if (mReader.IsRFIDModule && mReader.IsBarcodeModule)
            {
                return true;
            }
            return false;
        }
        void ReaderInitialized(AsReader reader)
        {
            enableAllButtons();
            if (!mReader.IsBarcodeModule)
            {
                disableBarcodeButtons();
            }
            else
            {
                AppDelegate.showGlobalProgressHUDWithTitle("Barcode Setting...");
                CATransaction.Commit();
                SystemSetting.sharedSystemSetting().barcodeSetting();
                AppDelegate.dismissGlobalHUD();
                CATransaction.Commit();
            }
            if (!mReader.IsRFIDModule)
            {
                disableRFIDButtons();
            }
            else
            {
                AppDelegate.showGlobalProgressHUDWithTitle("RFID Setting...");
                CATransaction.Commit();
                SystemSetting.sharedSystemSetting().RFIDSetting();
                AppDelegate.dismissGlobalHUD();
                CATransaction.Commit();
            }
        }

        void reloadData()
        {
            gunManager.onAsReaderGUNDisconnected = () => {
                AppDelegate.dismissGlobalHUD();
                disableAllUIs();
            };
            gunManager.accessResult = (error, action, epc, data, rssi, phase) => AccessResult(error, action, epc, data, rssi, phase);
            gunManager.onAsReaderLeftModeKeyEvent = (status) => OnAsReaderLeftModeKeyEvent(status);
            gunManager.onAsReaderRightModeKeyEvent = (status) => OnAsReaderRightModeKeyEvent(status);
            gunManager.readerInitialized = (reader) => ReaderInitialized(reader);
            if (mReader != null)
            {
                asRingPlusVersion.Text = asRingDeviceSDK.AsRingFirmwareRevision;
                AppDelegate.showGlobalProgressHUDWithTitle("Loading...");
                labelFirmwareVer.Text = mReader.FirmwareVersion;
                labelBluetoothAddr.Text = mReader.MAsReaderGUN.Address;
                int batteryStatus = mReader.BatteryStatus;
                changeBatteryImage(batteryStatus);
                enableAllButtons();
                if (!mReader.IsBarcodeModule)
                {
                    disableBarcodeButtons();
                }
                if (!mReader.IsRFIDModule)
                {
                    disableRFIDButtons();
                }
                regionLabel.Text = mReader.RegionName;
                snLabel.Text = mReader.SerialNumber;
                ufVersion.Text = mReader.RFModuleVersion;
                SystemSetting.sharedSystemSetting().asReaderGUNSetting();
                AppDelegate.dismissGlobalHUD();
            }
            else
            {
                disableAllUIs();
            }
        }

        void keyboardHide()
        {
            mainScrollView.ScrollEnabled = true;
            backView.RemoveFromSuperview();
            vibratorTextField.ResignFirstResponder();
            buzzerTextField.ResignFirstResponder();
            if (buzzerTextField.Text == "") buzzerTextField.Text = "0";
            if (int.Parse(buzzerTextField.Text) == 0)
            {
                buzzerTextField.Text = "1";
            }
            if (int.Parse(vibratorTextField.Text) == 0)
            {
                vibratorTextField.Text = "1";
            }

            if (int.Parse(buzzerTextField.Text) > 4999)
            {
                UIAlertController alert = UIAlertController.Create("Buzzer Value", "Please enter the value (1~4999)", UIAlertControllerStyle.Alert);
                UIAlertAction cancelAction = UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null);
                alert.AddAction(cancelAction);
                PresentViewController(alert, true, null);
                buzzerTextField.Text = "4999";
            }
            if (int.Parse(vibratorTextField.Text) > 4999)
            {
                UIAlertController alert = UIAlertController.Create("Vibrator Value", "Please enter the value (1~4999)", UIAlertControllerStyle.Alert);
                UIAlertAction cancelAction = UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null);
                alert.AddAction(cancelAction);
                PresentViewController(alert, true, null);
                vibratorTextField.Text = "4999";
            }


            SystemSetting.sharedSystemSetting().setVibratorTime(int.Parse(vibratorTextField.Text));
            SystemSetting.sharedSystemSetting().setBuzzerTime(int.Parse(buzzerTextField.Text));
            mainScrollView.SetContentOffset(new CoreGraphics.CGPoint(0, 100), true);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            reloadData();
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        partial void onClickBuzzerButton(UIButton sender)
        {
            int buzzerTime = int.Parse(buzzerTextField.Text);
            
            if (buzzerTime > 0 && buzzerTime < 5000)
            {
                SystemSetting.sharedSystemSetting().setBuzzerTime(buzzerTime);
                ResultCode resultCode = mReader.StartBuzzerWithBuzzerTime(buzzerTime);
            }
            else
            {
                UIAlertView alert = new UIAlertView("Buzzer Value", "Please enter the value (1~4999)", null, "OK", null);
                alert.Show();
            }
        }
        partial void onClickVibratorButton(UIButton sender)
        {
            int vibrator = int.Parse(vibratorTextField.Text);

            if (vibrator > 0 && vibrator < 5000)
            {
                SystemSetting.sharedSystemSetting().setVibratorTime(vibrator);
                ResultCode resultCode = mReader.StartVibratorWithVibratorTime(vibrator);
            }
            else
            {
                UIAlertView alert = new UIAlertView("Vibrator Value", "Please enter the value (1~4999)", null, "OK", null);
                alert.Show();
            }
        }

#pragma mark - Navigation
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            //base.PrepareForSegue(segue, sender);
        }
#pragma mark - Storyboard Segue
        public override void PrepareForInterfaceBuilder()
        {
            //base.PrepareForInterfaceBuilder();
        }

        void logoDebugTapDetected(UITapGestureRecognizer sender) 
        {
            if (sender.State == UIGestureRecognizerState.Ended)
            {
                UIActionSheet actionSheet = new UIActionSheet("Please select the operationg mode.",new MyActionSheetDelegate(this),"Debug Mode","Normal Mode",null);
                actionSheet.Tag = 200;
                actionSheet.ShowInView(View);
            }
        }

        #pragma mark - Custom
        void enableAllButtons()
        {
            foreach (MainButton btn in buttonCollection)
            {
                btn.enableButton();
            }
            changeLogoImage(CONNECTION_ON);

            buzzerButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            vibratorButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            buzzerTextField.Text = SystemSetting.sharedSystemSetting().getBuzzerTime().ToString();
            vibratorTextField.Text = SystemSetting.sharedSystemSetting().getVibratorTime().ToString();
            buzzerTextField.Enabled = true;
            vibratorTextField.Enabled = true;
            buzzerButton.Enabled = true;
            vibratorButton.Enabled = true;
        }

        void disableAllUIs()
        {
            keyboardHide();
            mainScrollView.SetContentOffset(new CoreGraphics.CGPoint(0, 0), true);

            asRingPlusVersion.Text = "";
            labelFirmwareVer.Text = "";
            labelBluetoothAddr.Text = "";
            regionLabel.Text = "";
            snLabel.Text = "";
            ufVersion.Text = "";

            buzzerButton.SetTitleColor(UIColor.Gray, UIControlState.Normal);
            vibratorButton.SetTitleColor(UIColor.Gray, UIControlState.Normal);
            buzzerTextField.Text = SystemSetting.sharedSystemSetting().getBuzzerTime().ToString();
            vibratorTextField.Text = SystemSetting.sharedSystemSetting().getVibratorTime().ToString();
            buzzerTextField.Enabled = false;
            vibratorTextField.Enabled = false;
            buzzerButton.Enabled = false;
            vibratorButton.Enabled = false;

            foreach (MainButton btn in buttonCollection)
            {
                btn.disableButton();
            }
            changeLogoImage(CONNECTION_OFF);
            changeBatteryImage(BATTERY_NONE);
        }

        void disableBarcodeButtons()
        {
            buttonCollection[4].disableButton();
            buttonCollection[5].disableButton();
        }

        void disableRFIDButtons()
        {
            buttonCollection[0].disableButton();
            buttonCollection[1].disableButton();
            buttonCollection[2].disableButton();
            buttonCollection[3].disableButton();
            buttonCollection[6].disableButton();
        }

        void changeBatteryImage(int batteryStatus)
        {
             if (batteryStatus == BATTERY_NONE) {
                batteryImage.Image = UIImage.FromBundle("battery0");
            } else if (batteryStatus == BATTERY_QUARTER) {
                batteryImage.Image = UIImage.FromBundle("battery1");
            } else if (batteryStatus == BATTERY_HALF) {
                batteryImage.Image = UIImage.FromBundle("battery2");
            } else if (batteryStatus == BATTERY_THIRD_QUARTER) {
                batteryImage.Image = UIImage.FromBundle("battery3");
            } else if (batteryStatus == BATTERY_FULL) {
                batteryImage.Image = UIImage.FromBundle("battery4");
            }
        }

        void changeLogoImage(int connectionStatus)
        {
            if (connectionStatus == CONNECTION_OFF)
            { 
                logoImage.Image = UIImage.FromBundle("asreaderlogoff");

                if (logoDebugTap != null)
                {
                    logoImage.UserInteractionEnabled = false;
                    logoImage.RemoveGestureRecognizer(logoDebugTap);
                    logoDebugTap = null;
                }
            }else if (connectionStatus == CONNECTION_ON)
            {
                logoImage.Image = UIImage.FromBundle("asreaderlogon");
                if (logoDebugTap != null)
                {
                    logoDebugTap = null;
                }
                logoDebugTap = new UITapGestureRecognizer(logoDebugTapDetected);
                logoDebugTap.NumberOfTapsRequired = 5;
                logoImage.UserInteractionEnabled = true;
                logoImage.AddGestureRecognizer(logoDebugTap);

            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //void disconnectDevice()
        //{
        //    if (mReader != null)
        //    {
        //        mReader.Disconnect();
        //    }
        //    mReader = null;
        //    disableAllUIs();;
        //}

        private class MyActionSheetDelegate : UIActionSheetDelegate
        {
            ViewController currentViewContorller;
            public MyActionSheetDelegate(ViewController controller)
            {
                currentViewContorller = controller;
            }

            public override void Clicked(UIActionSheet actionSheet, nint buttonIndex)
            {
                //base.Clicked(actionSheet, buttonIndex);
                if (actionSheet.Tag == 200)
                {
                    if (buttonIndex == 0)
                    {
                        currentViewContorller.mReader.SetDebugMode(false);
                    }else
                    {
                        currentViewContorller.mReader.SetDebugMode(true);
                    }
                }
            }
        }

        private class MyTextFieldDelegate : UITextFieldDelegate
        {
            ViewController currentViewContorller;
            public MyTextFieldDelegate(ViewController controller)
            {
                currentViewContorller = controller;
            }

            public override void EditingStarted(UITextField textField)
            {
                //base.EditingStarted(textField);
                currentViewContorller.mainScrollView.ScrollEnabled = false;
                currentViewContorller.View.AddSubview(currentViewContorller.backView);
                if (currentViewContorller.buzzerTextField.IsFirstResponder){
                    currentViewContorller.buzzerTextField.KeyboardType = UIKeyboardType.NumberPad;
                }else if(currentViewContorller.vibratorTextField.IsFirstResponder){
                    currentViewContorller.vibratorTextField.KeyboardType = UIKeyboardType.NumberPad;
                }
                currentViewContorller.mainScrollView.SetContentOffset(new CoreGraphics.CGPoint(0, 260), true);
            }

            public override bool ShouldChangeCharacters(UITextField textField, NSRange range, string replacementString)
            {
                if (int.Parse(textField.Text+replacementString) <= 0)
                {
                    textField.Text = "1";
                }

                return true;
            }
        }

        private class MyAlertViewDelegate : UIAlertViewDelegate
        {
            ViewController currentViewContorller;
            public MyAlertViewDelegate(ViewController controller)
            {
                currentViewContorller = controller;
            }

            public override void Clicked(UIAlertView alertview, nint buttonIndex)
            {
                //base.Clicked(alertview, buttonIndex);
                //switch (alertview.Tag)
                //{
                //    case 0:
                //        break;
                //    case 1:
                //        if (currentViewContorller.mReader != null)
                //        {
                //            currentViewContorller.mReader = null;
                //        }else
                //        {
                //            currentViewContorller.disconnectDevice();
                //        }
                //        break;
                //    case 2:
                //        if (buttonIndex != 0)
                //        {
                            
                //        }
                //        break;
                //    case 3:
                //        if (buttonIndex != 0)
                //        {

                //        }
                //        break;
                //}
            }
        }

    }
}
