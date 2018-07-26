// This file has been autogenerated from a class added in the UI designer.

using System;
using AsReaderGunSDK;
using Foundation;
using UIKit;

namespace AsReaderLR_VS
{
	public partial class BarcodeOption_VC : UIViewController
	{
        int PICKER_VIEW_BUZZER = 0;
        int PICKER_VIEW_Vibrator = 1;

        int ALERT_VIEW_BATTERY_INTERVAL = 10;
        int ALERT_VIEW_SLEEP_TIME = 11;

        AppDelegate appDelegate;
        SystemSetting systemSetting;

        string[] buzzerPickerData = {"Off", "Low", "High"};
        string[] vibratorPickerData = { "Off", "On"};

        BuzzerState buzzerValue;
        VibratorState vibratorValue;

        string batteryIntervalValue;
        int sleepTimeValue;

        AsReaderGUNManager gunManager = AsReaderGUNManager.sharedAsReaderGUNManager();

        AsReader mReader
        {
            get => gunManager.getCurrentAsReader();
        }

		public BarcodeOption_VC (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            scrollView.ContentSize = new CoreGraphics.CGSize(0,1000);
            scrollView.ShowsVerticalScrollIndicator = false;
            appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            systemSetting = SystemSetting.sharedSystemSetting();
            pickerView.DataSource = new MyPickerViewDataSource(this);
            pickerView.Delegate = new MyPickerViewDelegate(this);
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            gunManager.onAsReaderGUNDisconnected = () => {
                AppDelegate.dismissGlobalHUD();
                NavigationController.PopToRootViewController(true);
            };
            gunManager.onAsReaderLeftModeKeyEvent = (status) => OnAsReaderLeftModeKeyEvent(status);
            gunManager.onAsReaderRightModeKeyEvent = (status) => OnAsReaderRightModeKeyEvent(status);
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
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            if (mReader == null)
            {
                return;
            }
            AppDelegate.showGlobalProgressHUDWithTitle("Loading...");

            vibratorValue = mReader.Vibrator;
            buzzerValue = mReader.Buzzer;
            sleepTimeValue = mReader.SleepTime;
            initViewData();
            NavigationController.View.AddSubview(shadowView);
            AppDelegate.dismissGlobalHUD();
        }
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            gunManager.init();
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
        #pragma mark - IBAction
        partial void buzzerBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_BUZZER;
            pickerView.ReloadAllComponents();
            if (buzzerTextField.Text != "")
            {
                int index = Array.IndexOf(buzzerPickerData, buzzerTextField.Text);
                pickerView.Select((nint)index, 0, false);
            }
            else
            {
                pickerView.Select(0, 0, false);
            }
            buzzerPickerTopView.Hidden = false;
            showPickerView();
        }
        partial void vibratorBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_Vibrator;
            pickerView.ReloadAllComponents();
            if (vibratorTextField.Text != "")
            {
                int index = Array.IndexOf(vibratorPickerData, vibratorTextField.Text);
                pickerView.Select((nint)index, 0, false);
            }
            else
            {
                pickerView.Select(0, 0, false);
            }
            vibratorPickerTopView.Hidden = false;
            showPickerView();
        }
        partial void batteryIntervalBtnTapped(NSObject sender)
        {
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("Battery Interval:", "Please enter battery interval.", alertViewDelegate, "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.NumberPad;
            alert.Tag = ALERT_VIEW_BATTERY_INTERVAL;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void sleepTimeBtnTapped(NSObject sender)
        {
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("sleep Time:", "Please enter sleep time.", alertViewDelegate, "Cancel", null);
            alert.AlertViewStyle = UIAlertViewStyle.PlainTextInput;
            alert.GetTextField(0).KeyboardType = UIKeyboardType.NumberPad;
            alert.Tag = ALERT_VIEW_SLEEP_TIME;
            alert.AddButton("OK");
            alert.Show();
        }
        partial void saveBtnTapped(NSObject sender)
        {
            mReader.Buzzer = buzzerValue;
            mReader.Vibrator = vibratorValue;
            mReader.SleepTime = sleepTimeValue;

            systemSetting.setBuzzer((int)buzzerValue);
            systemSetting.setVibrator((int)vibratorValue);
            systemSetting.setSleepTime((int)sleepTimeValue);

            UserData.setBatteryInterval(batteryIntervalValue);
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("Success", "Saved successfully", alertViewDelegate, "OK", null);
            alert.Show();
        }
        partial void defaultBtnTapped(NSObject sender)
        {
            mReader.Buzzer = BuzzerState.High;
            mReader.Vibrator = VibratorState.n;
            mReader.SleepTime = 300;

            buzzerValue = mReader.Buzzer;
            vibratorValue = mReader.Vibrator;
            sleepTimeValue = mReader.SleepTime;

            systemSetting.setBuzzer((int)buzzerValue);
            systemSetting.setVibrator((int)vibratorValue);
            systemSetting.setSleepTime((int)sleepTimeValue);

            UserData.setBatteryInterval("1000");
            initViewData();
            MyAlertViewDelegate alertViewDelegate = new MyAlertViewDelegate(this);
            UIAlertView alert = new UIAlertView("Success", "Set to default successfully", alertViewDelegate, "OK", null);
            alert.Show();
        }
        partial void pickerCloseBtnTapped(NSObject sender)
        {
            hidePickerView();
        }
        partial void buzzerPickerOkBtnTapped(NSObject sender)
        {
            int idx = (int)pickerView.SelectedRowInComponent(0);
            setBuzzer(idx);
            hidePickerView();
        }
        partial void vibratorPickerOkBtnTapped(NSObject sender)
        {
            int idx = (int)pickerView.SelectedRowInComponent(0);
            setVibrator(idx);
            hidePickerView();
        }
        partial void tableCloseBtnTapped(NSObject sender)
        {
            hidePickerView();
        }
        #pragma mark - Custom
        void showPickerView()
        {
            pickerView.Hidden = false;
            shadowView.Hidden = false;
        }
        void hidePickerView()
        {
            vibratorPickerTopView.Hidden = true;
            buzzerPickerTopView.Hidden = true;
            pickerView.Hidden = true;
            shadowView.Hidden = true;
        }
        void hideTableView()
        {
            shadowView.Hidden = true;
        }
        void setBuzzer(int index)
        {
            buzzerTextField.Text = buzzerPickerData[index];
            buzzerValue = (BuzzerState)index;
        }
        void setVibrator(int index)
        {
            vibratorTextField.Text = vibratorPickerData[index];
            vibratorValue = (VibratorState)index;
        }
        void setBatteryInterval(string batteryInterval)
        {
            batteryIntervalTextField.Text = batteryInterval;
            batteryIntervalValue = batteryInterval;
        }
        void setSleepTime(string sleepTime)
        {
            sleepTimeTextField.Text = sleepTime;
            sleepTimeValue = int.Parse(sleepTime);
        }
        void initViewData()
        {
            setBuzzer((int)buzzerValue);
            setVibrator((int)vibratorValue);
            setSleepTime(sleepTimeValue.ToString());
            string batteryInterval = UserData.getBatteryInterval();
            setBatteryInterval(batteryInterval);
        }
        #pragma mark - UIPickerViewDelegate
        private class MyPickerViewDelegate : UIPickerViewDelegate
        {
            BarcodeOption_VC currentViewContorller;
            public MyPickerViewDelegate(BarcodeOption_VC controller)
            {
                currentViewContorller = controller;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_BUZZER)
                {
                    return currentViewContorller.buzzerPickerData[(int)row];
                }
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_Vibrator)
                {
                    return currentViewContorller.vibratorPickerData[(int)row];
                }
                return "None";
            }
        }
        private class MyPickerViewDataSource : UIPickerViewDataSource
        {
            BarcodeOption_VC currentViewContorller;
            public MyPickerViewDataSource(BarcodeOption_VC controller)
            {
                currentViewContorller = controller;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                //throw new NotImplementedException();
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_BUZZER)
                {
                    return currentViewContorller.buzzerPickerData.Length;
                }
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_Vibrator)
                {
                    return currentViewContorller.vibratorPickerData.Length;
                }
                return 0;
            }
        }
        #pragma mark - UIAlertViewDelegate
        private class MyAlertViewDelegate : UIAlertViewDelegate
        {
            BarcodeOption_VC currentViewContorller;
            public MyAlertViewDelegate(BarcodeOption_VC controller)
            {
                currentViewContorller = controller;
            }

            public override void Clicked(UIAlertView alertview, nint buttonIndex)
            {
                if (alertview.Tag == currentViewContorller.ALERT_VIEW_BATTERY_INTERVAL)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            currentViewContorller.setBatteryInterval(str);
                        }

                    }
                }
                else if (alertview.Tag == currentViewContorller.ALERT_VIEW_SLEEP_TIME)
                {
                    if (buttonIndex == 1)
                    {
                        UITextField textfield = alertview.GetTextField(0);
                        if (textfield != null)
                        {
                            string str = alertview.GetTextField(0).Text;
                            if (str == "") str = "0";
                            currentViewContorller.setSleepTime(str);
                        }
                    }
                }
            }
        }
	}
}