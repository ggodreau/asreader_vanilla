// This file has been autogenerated from a class added in the UI designer.

using System;
using AsReaderGunSDK;
using Foundation;
using UIKit;

namespace AsReaderLR_VS
{
	public partial class SelectionMaskViewController : UIViewController
	{
        int PICKER_VIEW_INVENTORY_SESSION = 0;
        int PICKER_VIEW_SESSION_FLAG = 1;
        int PICKER_VIEW_SELECT_FLAG = 2;

        AppDelegate appDelegate;
        SystemSetting systemSetting;
        bool isEditCell;

        NSMutableArray maskData = new NSMutableArray();

        SelectFlag selectFlag;
        SessionType inventorySession;
        SessionFlag sessionFlag;

        Define define;

        AsReaderGUNManager gunManager = AsReaderGUNManager.sharedAsReaderGUNManager();

        AsReader mReader
        {
            get => gunManager.getCurrentAsReader();
        }

		public SelectionMaskViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            systemSetting = SystemSetting.sharedSystemSetting();
            appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            enableActionWidgets(false);
            tableView.DataSource = new MyTableViewSource(this);
            tableView.Delegate = new MyTableViewDelegate(this);
            pickerView.DataSource = new MyPickerViewDataSource(this);
            pickerView.Delegate = new MyPickerViewDelegate(this);

            cancelBtn.TouchUpInside += (object sender, EventArgs e) => {
                NavigationController.PopViewController(true);
            };

            define = Define.sharedDefine();
            AppDelegate.showGlobalProgressHUDWithTitle("Loading...");
            if (mReader == null)
            {
                AppDelegate.dismissGlobalHUD();
                return;
            }
            initLoadMask();
            AppDelegate.dismissGlobalHUD();
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            isEditCell = false;
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

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
#pragma mark - IBAction
        partial void saveBtnTapped(NSObject sender)
        {
            enableActionWidgets(false);
            AppDelegate.showGlobalProgressHUDWithTitle("Saving...");
            for (int i = define.MIN_SELECTION_MASK; i < define.MAX_SELECTION_MASK; i++)
            {
                if (i < (int)maskData.Count)
                {
                    AsSelectMaskParam param = maskData.GetItem<AsSelectMaskParam>((nuint)i);
                    mReader.SetSelectionMask(i, param);
                }
                else
                {
                    mReader.RemoveSelectionMask(i);
                }
            }
            if (maskData.Count > 0)
            {
                mReader.UseSelectionMask = selectFlag + 1;
                systemSetting.setUseSelectionMask(selectFlag + 1);
            }
            else
            {
                mReader.ClearSelectionMask();
            }
            mReader.InventorySession = inventorySession;
            mReader.SessionFlag = sessionFlag;

            systemSetting.setInventorySession((int)inventorySession);
            systemSetting.setSessionFlag(sessionFlag);
            systemSetting.setEpcMaskData(maskData);
            enableActionWidgets(true);
            AppDelegate.dismissGlobalHUD();
            UIAlertView alert = new UIAlertView("Success", "Saved successfully", null, "OK", null);
            alert.Show();
            NavigationController.PopViewController(true);
        }
        partial void selectFlagBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_SELECT_FLAG;
            pickerView.ReloadAllComponents();
            pickerView.Select((nint)(uint)selectFlag, 0, false);
            pickerView.Hidden = false;
            selectFlagPickerTopView.Hidden = false;
        }
        partial void inventorySessionBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_INVENTORY_SESSION;
            pickerView.ReloadAllComponents();
            pickerView.Select((nint)(uint)inventorySession, 0, false);
            pickerView.Hidden = false;
            inventorySessionPickerTopView.Hidden = false;
        }
        partial void sessionFlagBtnTapped(NSObject sender)
        {
            pickerView.Tag = PICKER_VIEW_SESSION_FLAG;
            pickerView.ReloadAllComponents();
            pickerView.Select((nint)(uint)sessionFlag, 0, false);
            pickerView.Hidden = false;
            sessionFlagPickerTopView.Hidden = false;
        }
        partial void selectFlagPickerOkBtnTapped(NSObject sender)
        {
            setSelectFlag((SelectFlag)(uint)pickerView.SelectedRowInComponent(0));
            hidePickerView();
        }
        partial void inventorySessionPickerOkBtnTapped(NSObject sender)
        {
            setInventorySession((SessionType)(uint)pickerView.SelectedRowInComponent(0));
            hidePickerView();
        }
        partial void sessionFlagPickerOkBtnTapped(NSObject sender)
        {
            setSessionFlag((SessionFlag)(uint)pickerView.SelectedRowInComponent(0));
            hidePickerView();
        }
        partial void pickerCloseBtnTapped(NSObject sender)
        {
            hidePickerView();
        }
        #pragma mark - Setters
        void setSelectFlag(SelectFlag _selectFlag)
        {
            selectFlagTextField.Text = appDelegate.DATA_SELECT_FLAG[(int)_selectFlag];
            selectFlag = _selectFlag;
        }
        void setInventorySession(SessionType _inventorySession)
        {
            inventorySessionTextField.Text = appDelegate.DATA_INVENTORY_SESSION[(int)_inventorySession];
            inventorySession = _inventorySession;
        }
        void setSessionFlag(SessionFlag _sessionFlag)
        {
            sessionFlagTextField.Text = appDelegate.DATA_SESSION_FLAG[(int)_sessionFlag];
            sessionFlag = _sessionFlag;
        }
        #pragma mark - Custom
        void initLoadMask()
        {
            for (int i = define.MIN_SELECTION_MASK; i < define.MAX_SELECTION_MASK; i++)
            {
                if (!mReader.UsedSelectionMask(i))
                {
                    break;
                }
                AsSelectMaskParam param = mReader.GetSelectionMask(i);
                maskData.Add(param);
            }
            tableView.ReloadData();
            SelectFlag _selectFlag = mReader.UseSelectionMask;
            if (_selectFlag == SelectFlag.NotUsed)
            {
                _selectFlag = SelectFlag.Sl;
            }
            setSelectFlag(_selectFlag - 1);
            setInventorySession(mReader.InventorySession);
            setSessionFlag(mReader.SessionFlag);
            enableActionWidgets(true);
        }
        void hidePickerView()
        {
            pickerView.Hidden = true;
            selectFlagPickerTopView.Hidden = true;
            inventorySessionPickerTopView.Hidden = true;
            sessionFlagPickerTopView.Hidden = true;
        }
        public void enableActionWidgets(bool enabled)
        {
            nuint count = maskData.Count;
            addBarButtonItem.Enabled = enabled && (int)count < define.MAX_SELECTION_MASK;
            saveBtn.Enabled = enabled;
            cancelBtn.Enabled = enabled;
        }
#pragma mark - Navigation
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "SelectionMaskCell")
            {
                SelectionMaskEditViewController vc = (SelectionMaskEditViewController)segue.DestinationViewController;
                NSIndexPath indexPath = tableView.IndexPathForCell((UITableViewCell)sender);
                vc.selectMaskParam = maskData.GetItem<AsSelectMaskParam>((uint)indexPath.Row);
                isEditCell = true;
            }
        }
#pragma mark - Storyboard Segue
       partial void prepareForUnwind(UIStoryboardSegue segue)
        {
            SelectionMaskEditViewController sourceViewController = (SelectionMaskEditViewController)segue.SourceViewController;
            if (!isEditCell)
            {
                maskData.Add(sourceViewController.selectMaskParam);
            }
            tableView.ReloadData();
        }
        private class MyTableViewDelegate : UITableViewDelegate
        {
            SelectionMaskViewController currentViewContorller;
            public MyTableViewDelegate(SelectionMaskViewController controller)
            {
                currentViewContorller = controller;
            }

            public override UITableViewCellEditingStyle EditingStyleForRow(UITableView tableView, NSIndexPath indexPath)
            {
                return UITableViewCellEditingStyle.Delete;
            }

        }

        private class MyTableViewSource : UITableViewDataSource
        {
            SelectionMaskViewController currentViewContorller;
            public MyTableViewSource(SelectionMaskViewController controller)
            {
                currentViewContorller = controller;
            }

            public override nint NumberOfSections(UITableView tableView)
            {
                return 1;
            }

            public override nint RowsInSection(UITableView tableView, nint section)
            {
                return (nint)currentViewContorller.maskData.Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                SelectionMaskTableViewCell cell = (SelectionMaskTableViewCell)tableView.DequeueReusableCell("SelectionMaskCell", indexPath);
                AsSelectMaskParam maskParam = currentViewContorller.maskData.GetItem<AsSelectMaskParam>((uint)indexPath.Row);
                if (maskParam != null && cell != null)
                {
                    cell.targetLabel.Text = currentViewContorller.appDelegate.DATA_TARGET[(int)maskParam.Target];
                    cell.actionLabel.Text = AsMaskActionType.ToString(maskParam.Action,maskParam.Target);
                    cell.bankLabel.Text = currentViewContorller.appDelegate.DATA_BANK[(int)maskParam.Bank];
                    cell.offsetLabel.Text = ((uint)maskParam.Offset).ToString() + "bit";
                    cell.lengthLabel.Text = ((uint)maskParam.Length).ToString() + "bit";
                    cell.maskLabel.Text = maskParam.Mask;
                }

                return cell;
            }

            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
            {
                currentViewContorller.maskData.RemoveObject(indexPath.Row);
                tableView.ReloadData();
            }
        }
        #pragma mark - UIPickerViewDelegate
        private class MyPickerViewDelegate : UIPickerViewDelegate
        {
            SelectionMaskViewController currentViewContorller;
            public MyPickerViewDelegate(SelectionMaskViewController controller)
            {
                currentViewContorller = controller;
            }

            public override string GetTitle(UIPickerView pickerView, nint row, nint component)
            {
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_SELECT_FLAG)
                {
                    return currentViewContorller.appDelegate.DATA_SELECT_FLAG[row];
                }
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_INVENTORY_SESSION)
                {
                    return currentViewContorller.appDelegate.DATA_INVENTORY_SESSION[row];
                }
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_SESSION_FLAG)
                {
                    return currentViewContorller.appDelegate.DATA_SESSION_FLAG[row];
                }
                return "None";
            }
        }
        private class MyPickerViewDataSource : UIPickerViewDataSource
        {
            SelectionMaskViewController currentViewContorller;
            public MyPickerViewDataSource(SelectionMaskViewController controller)
            {
                currentViewContorller = controller;
            }

            public override nint GetComponentCount(UIPickerView pickerView)
            {
                //throw new NotImplementedException();
                return 1;
            }

            public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
            {
                //throw new NotImplementedException();
                if (pickerView.Tag == currentViewContorller.PICKER_VIEW_SELECT_FLAG)
                {
                    return currentViewContorller.appDelegate.DATA_SELECT_FLAG.Length;
                }
                else if (pickerView.Tag == currentViewContorller.PICKER_VIEW_INVENTORY_SESSION)
                {
                    return (nint)currentViewContorller.appDelegate.DATA_INVENTORY_SESSION.Length;
                }
                else if (pickerView.Tag == currentViewContorller.PICKER_VIEW_SESSION_FLAG)
                {
                    return (nint)currentViewContorller.appDelegate.DATA_SESSION_FLAG.Length;
                }
                return 0;
            }
        }
	}
}