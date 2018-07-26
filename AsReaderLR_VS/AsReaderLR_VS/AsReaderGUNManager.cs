using System;
using Foundation;
using AsReaderGunSDK;
using UIKit;

namespace AsReaderLR_VS
{
    public class AsReaderGUNManager:NSObject
    {
        public delegate void AccessResult(ResultCode error, CommandType action, string epc, string data, float rssi, float phase);
        public delegate void DetectBarcode(BarcodeType barcodeType, string codeId, string barcode);
        public delegate void DetectBarcodeData(BarcodeType barcodeType, string codeId, NSData barcodeData);
        public delegate void CommandComplete(CommandType command);
        public delegate void ChangedActionState(CommandType action, nint resultCode);
        public delegate bool OnAsReaderTriggerKeyEvent(bool status);
        public delegate bool OnAsReaderLeftModeKeyEvent(bool status);
        public delegate bool OnAsReaderRightModeKeyEvent(bool status);
        public delegate void ReaderInitialized(AsReader reader);
        public delegate void UpdateDeviceState(ResultCode error);
        public delegate void ReadTag(string tag, float rssi, float phase, float frequency);
        public delegate void OnAsReaderGUNConnected();
        public delegate void OnAsReaderGUNDisconnected();

        public AccessResult accessResult;
        public DetectBarcode detectBarcode;
        public DetectBarcodeData detectBarcodeData;
        public CommandComplete commandComplete;
        public ChangedActionState changedActionState;
        public OnAsReaderTriggerKeyEvent onAsReaderTriggerKeyEvent;
        public OnAsReaderLeftModeKeyEvent onAsReaderLeftModeKeyEvent;
        public OnAsReaderRightModeKeyEvent onAsReaderRightModeKeyEvent;
        public ReaderInitialized readerInitialized;
        public UpdateDeviceState updateDeviceState;
        public ReadTag readTag;
        public OnAsReaderGUNConnected onAsReaderGUNConnected;
        public OnAsReaderGUNDisconnected onAsReaderGUNDisconnected;

        static AsReaderGUNManager uniqueInstance;
        static readonly object locker = new object();

        static AsReaderGUN mAsReaderGUN;
        static AsReader mReader;
        static MyAsreaderDelegate mAsreaderDelegate;

        SelectFlag backupUseMask;
        NSMutableArray backupSelectMasks = new NSMutableArray();
        Define define = Define.sharedDefine();

        public static AsReaderGUNManager sharedAsReaderGUNManager()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new AsReaderGUNManager();
                    }
                }
            }
            return uniqueInstance;
        }
        public AsReaderGUNManager()
        {
            mAsReaderGUN = new AsReaderGUN("com.asreader.gun");

            mAsreaderDelegate = new MyAsreaderDelegate(this);

            NSNotificationCenter center = NSNotificationCenter.DefaultCenter;
            NSString connectedStr = new NSString("AsReaderGUNConnected");
            NSString disconnectedStr = new NSString("AsReaderGUNDisconnected");

            center.AddObserver(connectedStr, AsReaderGUNConnected);
            center.AddObserver(disconnectedStr, AsReaderGUNDisconnected);
        }

        public AsReader getCurrentAsReader()
        {
            return mReader;
        }

        public void init()
        {
            accessResult = null;
            detectBarcode = null;
            commandComplete = null;
            changedActionState = null;
            onAsReaderTriggerKeyEvent = null;
            onAsReaderLeftModeKeyEvent = null;
            onAsReaderRightModeKeyEvent = null;
            readerInitialized = null;
            updateDeviceState = null;
            readTag = null;
            onAsReaderGUNDisconnected = null;
        }

        public void initMask(string maskValue, MaskType maskType)
        {
            if (maskValue != null)
            {
                if (maskType == MaskType.Selection)
                {
                    backupUseMask = mReader.UseSelectionMask;

                    for (int i = define.MIN_SELECTION_MASK; i < define.MAX_SELECTION_MASK; i++)
                    {
                        if (!mReader.UsedSelectionMask(i))
                        {
                            break;
                        }

                        AsSelectMaskParam maskParam = mReader.GetSelectionMask(i);
                        backupSelectMasks.Add(maskParam);
                    }
                }
                AsSelectMaskParam param = new AsSelectMaskParam(0, MaskTargetType.L, MaskActionType.Ab, MemoryBank.Epc, 32, maskValue.Substring(4), true);
                mReader.SetSelectionMask(0, param);
                mReader.UseSelectionMask = SelectFlag.Sl;

                for (int i = 1; i < define.MAX_SELECTION_MASK; i++)
                {
                    mReader.SetMaskUsed(i, false);
                }
            }

        }

        public void exitMask()
        {
            mReader.UseSelectionMask = backupUseMask;

            for (int i = define.MIN_SELECTION_MASK; i < define.MAX_SELECTION_MASK; i++)
            {
                if ((int)backupSelectMasks.Count < i + 1)
                {
                    mReader.RemoveSelectionMask(i);
                    break;
                }

                AsSelectMaskParam param = backupSelectMasks.GetItem<AsSelectMaskParam>((nuint)i);

                if (param == null)
                {
                    break;
                }
                mReader.SetSelectionMask(i, param);

            }
            backupSelectMasks.RemoveAllObjects();
        }

        class MyAsreaderDelegate : AsReaderDelegate
        {
            AsReaderGUNManager gunManager;
            public MyAsreaderDelegate(AsReaderGUNManager _gunManager)
            {
                gunManager = _gunManager;
            }


            public override void AccessResult(ResultCode error, CommandType action, string epc, string data, float rssi, float phase)
            {
                if (gunManager.accessResult != null) gunManager.accessResult(error,action,epc,data,rssi,phase);
            }
            public override void DetectBarcode(BarcodeType barcodeType, string codeId, string barcode)
            {
                if (gunManager.detectBarcode != null) gunManager.detectBarcode(barcodeType,codeId,barcode);
            }

            public override void DetectBarcode(BarcodeType barcodeType, string codeId, NSData barcodeData)
            {
                if (gunManager.detectBarcodeData != null) gunManager.detectBarcodeData(barcodeType, codeId, barcodeData);
            }
            public override void CommandComplete(CommandType command)
            {
                if (gunManager.commandComplete != null) gunManager.commandComplete(command);
            }
            public override void ChangedActionState(CommandType action, nint resultCode)
            {
                if (gunManager.changedActionState != null) gunManager.changedActionState(action, resultCode);
            }
            public override bool OnAsReaderTriggerKeyEvent(bool status)
            {
                if (gunManager.onAsReaderTriggerKeyEvent != null) return gunManager.onAsReaderTriggerKeyEvent(status);
                return false;
            }
            public override bool OnAsReaderLeftModeKeyEvent(bool status)
            {
                if (gunManager.onAsReaderLeftModeKeyEvent != null) return gunManager.onAsReaderLeftModeKeyEvent(status);
                return false;
            }
            public override bool OnAsReaderRightModeKeyEvent(bool status)
            {
                if (gunManager.onAsReaderRightModeKeyEvent != null) return gunManager.onAsReaderRightModeKeyEvent(status);
                return false;
            }
            public override void ReaderInitialized(AsReader reader)
            {
                if (gunManager.readerInitialized != null) gunManager.readerInitialized(reader);
            }

            public override void UpdateDeviceState(ResultCode error)
            {
                if (gunManager.updateDeviceState != null) gunManager.updateDeviceState(error);
            }

            public override void ReadTag(string tag, float rssi, float phase, float frequency)
            {
                if (gunManager.readTag != null) gunManager.readTag(tag, rssi, phase, frequency);
            }
        }
        void AsReaderGUNConnected(NSNotification notification)
        {
            mReader = new AsReader(mAsReaderGUN, mAsreaderDelegate);
            if (onAsReaderGUNConnected != null && mReader != null)
            {
                onAsReaderGUNConnected();
            } 
        }

        void AsReaderGUNDisconnected(NSNotification notification)
        {
            if (mReader != null)
            {
                if (onAsReaderGUNDisconnected != null) onAsReaderGUNDisconnected();
                mReader = null;
            }
        }
    }
}
