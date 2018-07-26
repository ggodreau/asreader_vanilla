// This file has been autogenerated from a class added in the UI designer.

using System;
using AsReaderGunSDK;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace AsReaderLR_VS
{
	public partial class TagAccessViewController : UIViewController
	{
        public string maskValue;
        int PICKER_VIEW_POWER_GAIN = 0;

        int ALERT_VIEW_PASSWORD = 0;
        int ALERT_VIEW_OPERATION_TIME = 1;
        int ALERT_VIEW_SET_ACCESS_PW = 2;
        int ALERT_VIEW_SET_KILL_PW = 3;
        int ALERT_VIEW_KILL_PW = 4;
        int ALERT_VIEW_LOCK = 5;

        int ALERT_VIEW_OUTHERVIEW = 30;
        string MSG_TAG_WAIT = "Tag memory to lock or kill,\nPlease click the button";

        AppDelegate appDelegate;
        UIAlertView currentAlertView;
        bool isActionResult;
        MaskType maskType;
        SystemSetting systemSetting;

        List<string> powerGainPickerData = new List<string>();

        AsReaderGUNManager gunManager = AsReaderGUNManager.sharedAsReaderGUNManager();

        AsReader mReader
        {
            get => gunManager.getCurrentAsReader();
        }

		public TagAccessViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            systemSetting = SystemSetting.sharedSystemSetting();
            appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            pickerView.DataSource = new MyPickerViewDataSource(this);
            pickerView.Delegate = new MyPickerViewDelegate(this);
            int min = mReader.PowerGainRange.min;
            int max = mReader.PowerGainRange.max;
            for (int i = min; i <= max; i += 10)
            {
                powerGainPickerData.Add((i / 10).ToString() + ".0 dB");
            }
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            gunManager.onAsReaderGUNDisconnected = () => {
                AppDelegate.dismissGlobalHUD();
                NavigationController.PopToRootViewController(true);
            };
            gunManager.accessResult = (error, action, epc, data, rssi, phase) => AccessResult(error, action, epc, data, rssi, phase);
            gunManager.onAsReaderLeftModeKeyEvent = (status) => OnAsReaderLeftModeKeyEvent(status);
            gunManager.onAsReaderRightModeKeyEvent = (status) => OnAsReaderRightModeKeyEvent(status);
            gunManager.changedActionState = (action, resultCode) => ChangedActionState(action, resultCode);
            gunManager.onAsReaderTriggerKeyEvent = (status) => OnAsReaderTriggerKeyEvent(status);
            gunManager.updateDeviceState = (error) => UpdateDeviceState(error);
        }
        bool OnAsReaderTriggerKeyEvent(bool status)
        {
            if (status)
            {
                if (currentAlertView != null)
                {
                    currentAlertView.DismissWithClickedButtonIndex(0, true);
                }
                currentAlertView = new UIAlertView("Error", "For this page no Trigger key function.", null, "OK", null);
                currentAlertView.Tag = ALERT_VIEW_OUTHERVIEW;
                currentAlertView.Show();
            }
            return false;
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
        void UpdateDeviceState(ResultCode error)
        {
            if (error != ResultCode.NoError)
            {
                if (currentAlertView != null)
                {
                    currentAlertView.DismissWithClickedButtonIndex(0, true);
                }
                currentAlertView = new UIAlertView("Error", "Failed to get response. Try again.", null, "OK", null);
                currentAlertView.Tag = ALERT_VIEW_OUTHERVIEW;
                currentAlertView.Show();
                NavigationController.PopViewController(true);
            }
        }
        void ChangedActionState(CommandType action, nint resultCode)
        {
            if (currentAlertView != null)
            {
                currentAlertView.DismissWithClickedButtonIndex(0, true);
            }
            if (action == CommandType.Stop)
            {
                if (isActionResult == false)
                {
                    messageLabel.Text = MSG_TAG_WAIT;
                }
            }
            else
            {
                currentAlertView = new UIAlertView("On progress", "Waiting Tag Memory", null, "Stop", null);
                currentAlertView.Tag = ALERT_VIEW_LOCK;
                currentAlertView.Show();
            }
        }
        void AccessResult(ResultCode error, CommandType action, string epc, string data, float rssi, float phase)
        {
            if (currentAlertView != null)
            {
                currentAlertView.DismissWithClickedButtonIndex(0, true);
            }
            isActionResult = true;
            selectionTagLabel.Text = epc;
            if (error != ResultCode.NoError)
            {
                messageLabel.Text = AsResultCode.Msg(error);
                currentAlertView = new UIAlertView("Error", AsResultCode.Msg(error), null, "OK", null);
                currentAlertView.Tag = ALERT_VIEW_OUTHERVIEW;
                currentAlertView.Show();
                return;
            }
            messageLabel.Text = "Success";

            if (reportRssiSwitch.On == false)
            {
                setReportRssiModeDefault();
            }
            else
            {
                rssiLabel.Text = Math.Round(rssi, 1).ToString() + " dB";
                phaseLabel.Text = Math.Round(phase, 1).ToString() + "˚";
            }
            currentAlertView = new UIAlertView("Success", "Lock memory successfully", null, "OK", null);
            currentAlertView.Tag = ALERT_VIEW_OUTHERVIEW;
            currentAlertView.Show();
        }
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if (mReader == null)
            {
                return;
            }
            AppDelegate.showGlobalProgressHUDWithTitle("Loading...");

            int nPower = mReader.PowerGain;
            int operationTime = mReader.OperationTime;
            mReader.ContinuousMode = false;
            bool isReportRSSI = mReader.RssiMode;
            maskType = (MaskType)mReader.MaskTypeValue;
            if (maskValue != null)
            {
                gunManager.initMask(maskValue, MaskType.Selection);
            }

            isActionResult = false;
            setPowerGain(nPower / 10);
            setOperationTime(operationTime.ToString());
            setReportRssiModeEnabled(isReportRSSI);
            pickerView.ReloadAllComponents();

            if (maskValue != null)
            {
                selectionTagLabel.Text = maskValue;
                maskBtn.Enabled = false;
            }
            AppDelegate.dismissGlobalHUD();
        }
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            if (maskValue != null)
            {
                gunManager.exitMask();
            }
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        #pragma mark - IBAction
        partial void passwordBtnTapped(NSObject sender)
        {
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("Password:", "Please enter password.", alertViewDelegate, "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.ASCIICapable;
            alert.GetTextField(0).Delegate = new MyTextFieldDelegate(this);
            alert.Tag = ALERT_VIEW_PASSWORD;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void powerGainBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_POWER_GAIN;
            pickerView.ReloadAllComponents();
            if (powerGainTextField.Text != "")
            {
                pickerView.Select((nint)powerGainPickerData.IndexOf(new NSString(powerGainTextField.Text)), 0, false);
            }
            else
            {
                pickerView.Select(0, 0, false);
            }
            pickerView.Hidden = false;
            powerGainPickerTopView.Hidden = false;
        }
        partial void operationTimeBtnTapped(NSObject sender)
        {
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("Operation Time:", "Please enter operation time.\n(ex: 30 ms)", alertViewDelegate, "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.NumberPad;
            alert.Tag = ALERT_VIEW_OPERATION_TIME;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void reportRssiSwitchTapped(NSObject sender)
        {
            mReader.RssiMode = reportRssiSwitch.On;
            systemSetting.setRssiMode(reportRssiSwitch.On);
            setReportRssiModeEnabled(reportRssiSwitch.On);
        }
        partial void lockBtnTapped(NSObject sender)
        {
            isActionResult = false;
            mReader.AccessPassword = passwordTextField.Text;

            LockParam param = new LockParam();
            param.KillPassword = killPasswordSwitch.On;
            param.AccessPassword = accessPasswordSwitch.On;
            param.Epc = epcSwitch.On;
            param.Tid = tidSwitch.On;
            param.User = userSwitch.On;
            if (operationTimeTextField.Text == "") operationTimeTextField.Text = "0";
            int time = int.Parse(operationTimeTextField.Text);

            mReader.OperationTime = time;
            systemSetting.setOperationTime(time);
            mReader.Lock(param);
        }
        partial void unlockBtnTapped(NSObject sender)
        {
            isActionResult = false;
            mReader.AccessPassword = passwordTextField.Text;

            LockParam param = new LockParam();
            param.KillPassword = killPasswordSwitch.On;
            param.AccessPassword = accessPasswordSwitch.On;
            param.Epc = epcSwitch.On;
            param.Tid = tidSwitch.On;
            param.User = userSwitch.On;
            if (operationTimeTextField.Text == "") operationTimeTextField.Text = "0";
            int time = int.Parse(operationTimeTextField.Text);

            mReader.OperationTime = time;
            systemSetting.setOperationTime(time);
            mReader.Unlock(param);
        }
        partial void permalockBtnTapped(NSObject sender)
        {
            isActionResult = false;
            mReader.AccessPassword = passwordTextField.Text;

            LockParam param = new LockParam();
            param.KillPassword = killPasswordSwitch.On;
            param.AccessPassword = accessPasswordSwitch.On;
            param.Epc = epcSwitch.On;
            param.Tid = tidSwitch.On;
            param.User = userSwitch.On;
            if (operationTimeTextField.Text == "") operationTimeTextField.Text = "0";
            int time = int.Parse(operationTimeTextField.Text);

            mReader.OperationTime = time;
            systemSetting.setOperationTime(time);
            mReader.PermaLock(param);
        }
        partial void killBtnTapped(NSObject sender)
        {
            isActionResult = false;
            UIAlertView alert = new UIAlertView("Kill Password:", "Please enter password.", new MyAlertViewDelegate(this), "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.ASCIICapable;
            alert.GetTextField(0).Delegate = new MyTextFieldDelegate(this);
            alert.Tag = ALERT_VIEW_KILL_PW;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void setAccessPwdBtnTapped(NSObject sender)
        {
            isActionResult = false;
            UIAlertView alert = new UIAlertView("Set Access Password:", "Please enter password.", new MyAlertViewDelegate(this), "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.ASCIICapable;
            alert.GetTextField(0).Delegate = new MyTextFieldDelegate(this);
            alert.Tag = ALERT_VIEW_SET_ACCESS_PW;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void setKillPwdBtnTapped(NSObject sender)
        {
            isActionResult = false;
            UIAlertView alert = new UIAlertView("Set Kill Password:", "Please enter password.", new MyAlertViewDelegate(this), "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.ASCIICapable;
            alert.GetTextField(0).Delegate = new MyTextFieldDelegate(this);
            alert.Tag = ALERT_VIEW_SET_KILL_PW;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void clearBtnTapped(NSObject sender)
        {
            selectionTagLabel.Text = "Result";
            messageLabel.Text = MSG_TAG_WAIT;
            rssiLabel.Text = @"0.0 dB";
            phaseLabel.Text = @"0.0˚";
        }
        partial void maskBtnTapped(NSObject sender)
        {
            if (maskType == MaskType.Selection)
            {
                PerformSegue("SelectionMask", this);
            }
            else
            {
                if (currentAlertView != null)
                {
                    currentAlertView.DismissWithClickedButtonIndex(0, true);
                }
                currentAlertView = new UIAlertView("", "Please set the mask type in RFID Options menu before using mask.", new MyAlertViewDelegate(this), "OK", null);
                currentAlertView.Tag = ALERT_VIEW_OUTHERVIEW;
                currentAlertView.Show();
            }
        }
        partial void pickerCloseBtnTapped(NSObject sender)
        {
            hidePickerView();
        }
        partial void powerGainPickerOkBtnTapped(NSObject sender)
        {
            nint idx = pickerView.SelectedRowInComponent(0);
            idx += mReader.PowerGainRange.min / 10;
            setPowerGain(idx);
            mReader.PowerGain = (int)idx * 10;
            systemSetting.setPowerGain((int)idx * 10);
            hidePickerView();
        }
        #pragma mark - Custom
        void hidePickerView()
        {
            powerGainPickerTopView.Hidden = true;
            pickerView.Hidden = true;
        }
        void setPassword(string password)
        {
            passwordTextField.Text = password;
        }
        void setPowerGain(nint power)
        {
            NSString value = new NSString(power.ToString() + ".0 dB");
            int index = (int)powerGainPickerData.IndexOf(value);
            if (powerGainPickerData.Count > index)
            {
                powerGainTextField.Text = powerGainPickerData[index];
            }
        }
        void setOperationTime(string operationTime)
        {
            operationTimeTextField.Text = operationTime;
        }
        void stopAction()
        {
            ResultCode code = mReader.Stop;
        }
        void setReportRssiModeEnabled(bool enabled)
        {
            foreach (UILabel elem in reportRssiCollection)
            {
                elem.Enabled = enabled;
            }
            if (enabled == false)
            {
                setReportRssiModeDefault();
            }
            reportRssiSwitch.On = enabled;
        }
        void setReportRssiModeDefault()
        {
            rssiLabel.Text = "0.0 dB";
            phaseLabel.Text = "0.0˚";
        }
        #pragma mark - UIPickerViewDataSource
        private class MyPickerViewDataSource : UIPickerViewDataSource
        {
            TagAccessViewController currentViewContorller;
            public MyPickerViewDataSource(TagAccessViewController controller)
            {
                currentViewContorller = controller;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                 if (pickerView.Tag == currentViewContorller.PICKER_VIEW_POWER_GAIN)
                {
                    return currentViewContorller.powerGainPickerData.Count;
                }
                return 0;
            }
        }

        private class MyPickerViewDelegate : UIPickerViewDelegate
        {
            TagAccessViewController currentViewContorller;
            public MyPickerViewDelegate(TagAccessViewController controller)
            {
                currentViewContorller = controller;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                 if (pickerView.Tag == currentViewContorller.PICKER_VIEW_POWER_GAIN)
                {
                    return currentViewContorller.powerGainPickerData[(int)row];
                }
                return "None";
            }
        }
        #pragma mark - UITextViewDelegate
        private class MyTextFieldDelegate : UITextFieldDelegate
        {
            TagAccessViewController currentViewContorller;
            public MyTextFieldDelegate(TagAccessViewController controller)
            {
                currentViewContorller = controller;
            }

            public override bool ShouldChangeCharacters(UITextField textField, NSRange range, string replacementString)
            {
                if (range.Length == 1)
                {
                    return true;
                }
                long textlen = textField.Text.Length + replacementString.Length - range.Length;
                if (textlen > currentViewContorller.appDelegate.MAX_PASSWORD_LENGTH)
                {
                    return false;
                }

                string a = "0123456789ABCDEFabcdef";

                if (a.IndexOf(replacementString) > -1)
                {
                    string str = textField.Text + replacementString;
                    textField.Text = str.ToUpper();
                }
                return false;
            }

        }
        #pragma mark - UIAlertViewDelegate
        private class MyAlertViewDelegate : UIAlertViewDelegate
        {
            TagAccessViewController currentViewContorller;
            public MyAlertViewDelegate(TagAccessViewController controller)
            {
                currentViewContorller = controller;
            }

            public override void Clicked(UIAlertView alertview, nint buttonIndex)
            {
                 if (alertview.Tag == currentViewContorller.ALERT_VIEW_OPERATION_TIME)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            currentViewContorller.setOperationTime(str);
                            currentViewContorller.mReader.OperationTime = int.Parse(str);
                            currentViewContorller.systemSetting.setOperationTime(int.Parse(str));
                        }

                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_PASSWORD)
                {
                    if (buttonIndex == 1)
                    {
                        currentViewContorller.setPassword(alertview.GetTextField(0).Text);
                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_SET_ACCESS_PW)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            currentViewContorller.mReader.AccessPassword = currentViewContorller.passwordTextField.Text;
                            currentViewContorller.mReader.WriteMemory(MemoryBank.Reserved, 2, str);
                        }

                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_SET_KILL_PW)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            currentViewContorller.mReader.AccessPassword = currentViewContorller.passwordTextField.Text;
                            currentViewContorller.mReader.WriteMemory(MemoryBank.Reserved, 0, str);
                        }

                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_KILL_PW)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            if (str.Length != 8)
                            {
                                if (currentViewContorller.currentAlertView != null)
                                {
                                    currentViewContorller.currentAlertView.DismissWithClickedButtonIndex(0, true);
                                }
                                currentViewContorller.currentAlertView = new UIAlertView("Error", "Password length is not valid ", new MyAlertViewDelegate(currentViewContorller), "Cancel", null);
                                currentViewContorller.currentAlertView.Tag = currentViewContorller.ALERT_VIEW_OUTHERVIEW;
                                currentViewContorller.currentAlertView.Show();
                            }
                            else
                            {
                                currentViewContorller.mReader.Kill(str);
                            }
                        }
                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_LOCK)
                {
                    currentViewContorller.stopAction();
                }
            }
        }
	}
}