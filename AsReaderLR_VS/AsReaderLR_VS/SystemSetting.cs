using System;
using Foundation;
using UIKit;
using AsReaderGunSDK;
using System.Collections.Generic;
namespace AsReaderLR_VS
{
    public class SystemSetting:NSObject
    {
        NSString ISFIRSTUSED = new NSString("IsFirtUsed");
        NSString BUZZER = new NSString("Buzzer");
        NSString VIBRATOR = new NSString("Vibrator");
        NSString BUZZERTIME = new NSString("BuzzerTime");
        NSString VIBRATORTIME = new NSString("VibratorTime");
        NSString INVENTORYTIME = new NSString("InventoryTime");
        NSString IDLETIME = new NSString("IdleTime");
        NSString AUTOOFFTIME = new NSString("AutoOffTime");
        NSString QVALUE = new NSString("QValue");
        NSString ALGORITHM = new NSString("Algorithm");
        NSString MAXQ = new NSString("MaxQ");
        NSString MINQ = new NSString("MinQ");
        NSString SLEEPTIME = new NSString("SleepTime");
        NSString MASKTYPEVALUE = new NSString("MaskTypeValue");
        NSString LINKPROFILEVALUE = new NSString("LinkProfileValue");
        NSString DeFAULTLINKPROFILEVALUE = new NSString("DefaultLinkProfileValue");
        NSString OPERATIONTIME = new NSString("OperationTime");
        NSString POWERGAIN = new NSString("PowerGain");
        NSString INVENTORYSESSION = new NSString("InventorySession");
        string SESSIONFLAG = "SessionFlag";
        NSString USESELECTIONMASK = new NSString("UseSelectionMask");
        NSString CONTINUOUSMODE = new NSString("ContinuousMode");
        NSString RSSIMODE = new NSString("RssiMode");
        NSString PROPBARCODEMODE = new NSString("PropBarcodeMode");
        NSString EPCMASKMATCHMODE = new NSString("EpcMaskMatchMode");
        NSString DISPLAYPC = new NSString("Displaypc");
        NSString LBTITEMDATA = new NSString("LbtItemData");
        NSString EPCMASKDATA = new NSString("EpcMaskData");
        NSString SELECTIONEPCMASKDATA = new NSString("SelectionEpcMaskData");
        NSString BARCODEPARAMDATA = new NSString("barcodeParamData");
        NSString BARCODERESCANTIME = new NSString("BarcodeRescanTime");

        AppDelegate m_appdelegate;
        NSUserDefaults m_userDefaults;
        Define define;

        private static SystemSetting uniqueInstance;

        private static readonly object locker = new object();

        AsReaderGUNManager gunManager = AsReaderGUNManager.sharedAsReaderGUNManager();

        AsReader mReader
        {
            get => gunManager.getCurrentAsReader();
        }

        //init    
        public SystemSetting()
        {
            m_appdelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            m_userDefaults = NSUserDefaults.StandardUserDefaults;
            define = Define.sharedDefine();
        }

        //+ (SystemSetting*) sharedSystemSetting;
        public static SystemSetting sharedSystemSetting()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new SystemSetting();
                    }
                }
            }
            return uniqueInstance;
        }

        //- (void) asReaderGUNSetting;
        public void asReaderGUNSetting()
        {
            mReader.Buzzer = getBuzzer();
            mReader.Vibrator = getVibrator();
            mReader.SleepTime = getSleepTime();
        }

        //- (void) RFIDSetting;
        public void RFIDSetting()
        {
            if (mReader != null)
            {
                mReader.InventoryTime = getInventoryTime();
                mReader.IdleTime = getIdleTime();
                mReader.AutoOffTime = getAutoOffTime();
                mReader.QValue = getQValue();
                mReader.Algorithm = getAlgorithm();
                mReader.MaxQ = getMaxQ();
                mReader.MinQ = getMinQ();
                mReader.LinkProfileValue = getLinkProfileValue();
                mReader.DefaultLinkProfileValue = getDefaultLinkProfileValue();
                mReader.OperationTime = getOperationTime();
                mReader.PowerGain = getPowerGain();
                mReader.InventorySession = getInventorySession();
                mReader.SessionFlag = getSessionFlag();
                mReader.ContinuousMode = getContinuousMode();
                mReader.RssiMode = getRssiMode();

                mReader.MaskTypeValue = getMaskTypeValue();

                switch ((MaskType)getMaskTypeValue())
                {
                    case MaskType.NoMask:

                        break;
                    case MaskType.Selection:{
                            NSArray selectionArray = getEpcMaskData();
                            for (int i = define.MIN_SELECTION_MASK; i < define.MAX_SELECTION_MASK; i++)
                            {
                                if (i < (int)selectionArray.Count){
                                    AsSelectMaskParam param =  selectionArray.GetItem<AsSelectMaskParam>((nuint)i);
                                    mReader.SetSelectionMask(i,param);
                                }else{
                                    mReader.RemoveSelectionMask(i);
                                }
                            }
                            if (selectionArray.Count > 0)
							{
                                mReader.UseSelectionMask = getUseSelectionMask();
                            }else {
                                mReader.ClearSelectionMask();
                            }
                        }
						break;
                    case MaskType.Epc:{
							ResultCode resultCD = mReader.ClearEpcMask;
                            NSArray selectionEpcArray = getSelectionEpcMaskData();
                            int count = (int)selectionEpcArray.Count;
                            for (int i = 0; i < count; i++){
                                AsSelectMaskEPCParam mask = selectionEpcArray.GetItem<AsSelectMaskEPCParam>((nuint)i);
                                mReader.AddEpcMask(mask);
							}
                            if (getEpcMaskMatchMode()){
                                mReader.EpcMaskMatchMode = true;
                            }else{
                                mReader.EpcMaskMatchMode = false;
							}
						}
						break;
                    default:
                        break;

				}
            }
		}

        //- (void) barcodeSetting;
		public void barcodeSetting()
		{
            if (mReader != null)
            {
                mReader.SetPropBarcodeMode(true);
                ResultCode res = ResultCode.NoError;
                NSArray barcodeParamArray = getBarcodeParamData();
				int count = (int)barcodeParamArray.Count;
				for (int i = 0; i < count; i++)
				{
					AsParamValue paramValue= barcodeParamArray.GetItem<AsParamValue>((nuint)i);
                    res = mReader.SetBarcodeParam(paramValue);
					if (res != ResultCode.NoError)
					{
						return;
					}
				}
                mReader.SetPropBarcodeMode(false);
			}
		}

		//- (void) setFirstUser:(BOOL) isFirst;
        public void setFirstUser(bool isFirst)
		{
            m_userDefaults.SetBool(isFirst,ISFIRSTUSED);
            m_userDefaults.Synchronize();
		}

		//- (BOOL) getFirstUsed;
        public bool getFirstUsed()
		{
            return m_userDefaults.BoolForKey(ISFIRSTUSED);
		}

		//- (void) setBarcodeReScanTime:(int) barcodeReScanTime;
		public void setBarcodeReScanTime(int barcodeReScanTime)
		{
            m_userDefaults.SetInt(barcodeReScanTime, BARCODERESCANTIME);
			m_userDefaults.Synchronize();
		}

		//- (int) getBarcodeReScanTime;
		public int getBarcodeReScanTime()
		{
            return (int)m_userDefaults.IntForKey(BARCODERESCANTIME);
		}
		//- (void) setBuzzerTime:(int) buzzerTime;
		public void setBuzzerTime(int buzzerTime)
		{
			m_userDefaults.SetInt(buzzerTime, BUZZERTIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getBuzzerTime;
		public int getBuzzerTime()
		{
			return (int)m_userDefaults.IntForKey(BUZZERTIME);
		}
		//- (void) setVibratorTime:(int) vibratorTime;
		public void setVibratorTime(int vibratorTime)
		{
			m_userDefaults.SetInt(vibratorTime, VIBRATORTIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getVibratorTime;
		public int getVibratorTime()
		{
			return (int)m_userDefaults.IntForKey(VIBRATORTIME);
		}
		//- (void) setBuzzer:(int) buzzertType;
		public void setBuzzer(int buzzertType)
		{
			m_userDefaults.SetInt(buzzertType, BUZZER);
			m_userDefaults.Synchronize();
		}
		//- (int) getBuzzer;
		public BuzzerState getBuzzer()
		{
            return (BuzzerState)(uint)m_userDefaults.IntForKey(BUZZER);
		}
		//- (void) setVibrator:(int) vibratorType;
		public void setVibrator(int vibratorType)
		{
			m_userDefaults.SetInt(vibratorType, VIBRATOR);
			m_userDefaults.Synchronize();
		}
		//- (int) getVibrator;
		public VibratorState getVibrator()
		{
			return (VibratorState)(uint)m_userDefaults.IntForKey(VIBRATOR);
		}
		//- (void) setInventoryTime:(int) inventoryTime;
		public void setInventoryTime(int inventoryTime)
		{
			m_userDefaults.SetInt(inventoryTime, INVENTORYTIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getInventoryTime;
		public int getInventoryTime()
		{
			return (int)m_userDefaults.IntForKey(INVENTORYTIME);
		}
		//- (void) setIdleTime:(int) idleTime;
		public void setIdleTime(int idleTime)
		{
			m_userDefaults.SetInt(idleTime, IDLETIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getIdleTime;
		public int getIdleTime()
		{
			return (int)m_userDefaults.IntForKey(IDLETIME);
		}
		//- (void) setAutoOffTime:(int) autoOffTime;
		public void setAutoOffTime(int autoOffTime)
		{
			m_userDefaults.SetInt(autoOffTime, AUTOOFFTIME);
			m_userDefaults.Synchronize();
		}
		//
		//- (int) getAutoOffTime;
		public int getAutoOffTime()
		{
			return (int)m_userDefaults.IntForKey(AUTOOFFTIME);
		}
		//- (void) setQValue:(int) qValue;
		public void setQValue(int qValue)
		{
			m_userDefaults.SetInt(qValue, QVALUE);
			m_userDefaults.Synchronize();
		}
		//- (int) getQValue;
		public int getQValue()
		{
			return (int)m_userDefaults.IntForKey(QVALUE);
		}
		//- (void) setAlgorithm:(int) algorithm;
		public void setAlgorithm(int algorithm)
		{
			m_userDefaults.SetInt(algorithm, ALGORITHM);
			m_userDefaults.Synchronize();
		}
		//- (int) getAlgorithm;
		public AlgorithmType getAlgorithm()
		{
			return (AlgorithmType)(uint)m_userDefaults.IntForKey(ALGORITHM);
		}
		//- (void) setMaxQ:(int) maxQValue;
		public void setMaxQ(int maxQValue)
		{
			m_userDefaults.SetInt(maxQValue, MAXQ);
			m_userDefaults.Synchronize();
		}
		//- (int) getMaxQ;
		public int getMaxQ()
		{
			return (int)m_userDefaults.IntForKey(MAXQ);
		}
		//- (void) setMinQ:(int) minQValue;
		public void setMinQ(int minQValue)
		{
			m_userDefaults.SetInt(minQValue, MINQ);
			m_userDefaults.Synchronize();
		}
		//- (int) getMinQ;
		public int getMinQ()
		{
			return (int)m_userDefaults.IntForKey(MINQ);
		}
		//- (void) setSleepTime:(int) sleepTimeValue;
		public void setSleepTime(int sleepTimeValue)
		{
			m_userDefaults.SetInt(sleepTimeValue, SLEEPTIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getSleepTime;
		public int getSleepTime()
		{
			return (int)m_userDefaults.IntForKey(SLEEPTIME);
		}
		//- (void) setMaskTypeValue:(int) maskTypeValue;
		public void setMaskTypeValue(int maskTypeValue)
		{
			m_userDefaults.SetInt(maskTypeValue, MASKTYPEVALUE);
			m_userDefaults.Synchronize();
		}
		//- (int) getMaskTypeValue;
		public int getMaskTypeValue()
		{
			return (int)m_userDefaults.IntForKey(MASKTYPEVALUE);
		}
		//- (void) setLinkProfileValue:(int) linkProfileValue;
		public void setLinkProfileValue(int linkProfileValue)
		{
			m_userDefaults.SetInt(linkProfileValue, LINKPROFILEVALUE);
			m_userDefaults.Synchronize();
		}
		//- (int) getLinkProfileValue;
		public int getLinkProfileValue()
		{
			return (int)m_userDefaults.IntForKey(LINKPROFILEVALUE);
		}
		//- (void) setDefaultLinkProfileValue:(int) defaultLinkProfileValue;
		public void setDefaultLinkProfileValue(int defaultLinkProfileValue)
		{
			m_userDefaults.SetInt(defaultLinkProfileValue, DeFAULTLINKPROFILEVALUE);
			m_userDefaults.Synchronize();
		}
		//- (int) getDefaultLinkProfileValue;
		public int getDefaultLinkProfileValue()
		{
			return (int)m_userDefaults.IntForKey(DeFAULTLINKPROFILEVALUE);
		}
		//- (void) setOperationTime:(int) operationTime;
		public void setOperationTime(int operationTime)
		{
			m_userDefaults.SetInt(operationTime, OPERATIONTIME);
			m_userDefaults.Synchronize();
		}
		//- (int) getOperationTime;
		public int getOperationTime()
		{
			return (int)m_userDefaults.IntForKey(OPERATIONTIME);
		}

		//- (void) setPowerGain:(int) powerGain;
		public void setPowerGain(int powerGain)
		{
			m_userDefaults.SetInt(powerGain, POWERGAIN);
			m_userDefaults.Synchronize();
		}
		//- (int) getPowerGain;
		public int getPowerGain()
		{
			return (int)m_userDefaults.IntForKey(POWERGAIN);
		}
		//- (void) setInventorySession:(int) inventorySession;
		public void setInventorySession(int inventorySession)
		{
			m_userDefaults.SetInt(inventorySession, INVENTORYSESSION);
			m_userDefaults.Synchronize();
		}
		//- (int) getInventorySession;
		public SessionType getInventorySession()
		{
			return (SessionType)(uint)m_userDefaults.IntForKey(INVENTORYSESSION);
		}
		//- (void) setSessionFlag:(int) sessionFlag;
        public void setSessionFlag(SessionFlag sessionFlag)
		{
            m_userDefaults.SetInt((int)sessionFlag, SESSIONFLAG);
			m_userDefaults.Synchronize();
		}
		//- (int) getSessionFlag;
		public SessionFlag getSessionFlag()
		{
			return (SessionFlag)(uint)m_userDefaults.IntForKey(SESSIONFLAG);
		}
		//- (void) setUseSelectionMask:(int) useSelectionMask;
		public void setUseSelectionMask(SelectFlag useSelectionMask)
		{
            m_userDefaults.SetInt((int)useSelectionMask, USESELECTIONMASK);
			m_userDefaults.Synchronize();
		}
		//- (int) getUseSelectionMask;
		public SelectFlag getUseSelectionMask()
		{
            return (SelectFlag)(uint)m_userDefaults.IntForKey(USESELECTIONMASK);
		}
		//- (void) setContinuousMode:(BOOL) isContinuousMode;
        public void setContinuousMode(bool isContinuousMode)
		{
            m_userDefaults.SetBool(isContinuousMode, CONTINUOUSMODE);
			m_userDefaults.Synchronize();
		}
		//- (BOOL) getContinuousMode;
        public bool getContinuousMode()
		{
            return m_userDefaults.BoolForKey(CONTINUOUSMODE);
		}
		//- (void) setRssiMode:(BOOL) isRssiMode;
		public void setRssiMode(bool isRssiMode)
		{
			m_userDefaults.SetBool(isRssiMode, RSSIMODE);
			m_userDefaults.Synchronize();
		}
		//- (BOOL) getRssiMode;
		public bool getRssiMode()
		{
			return m_userDefaults.BoolForKey(RSSIMODE);
		}
		//- (void) setPropBarcodeMode:(BOOL) isPropBarcodeMode;
		public void setPropBarcodeMode(bool isPropBarcodeMode)
		{
			m_userDefaults.SetBool(isPropBarcodeMode, PROPBARCODEMODE);
			m_userDefaults.Synchronize();
		}
		//- (BOOL) getPropBarcodeMode;
		public bool getPropBarcodeMode()
		{
			return m_userDefaults.BoolForKey(PROPBARCODEMODE);
		}
		//- (void) setEpcMaskMatchMode:(BOOL) isEpcMaskMatchMode;
		public void setEpcMaskMatchMode(bool isEpcMaskMatchMode)
		{
			m_userDefaults.SetBool(isEpcMaskMatchMode, EPCMASKMATCHMODE);
			m_userDefaults.Synchronize();
		}
		//- (BOOL) getEpcMaskMatchMode;
		public bool getEpcMaskMatchMode()
		{
			return m_userDefaults.BoolForKey(EPCMASKMATCHMODE);
		}
		//- (void) setDisPlayPC:(BOOL) isDisplaypc;
		public void setDisPlayPC(bool isDisplaypc)
		{
			m_userDefaults.SetBool(isDisplaypc, DISPLAYPC);
			m_userDefaults.Synchronize();
		}
		//- (BOOL) getDisPlayPC;
		public bool getDisPlayPC()
		{
			return m_userDefaults.BoolForKey(DISPLAYPC);
		}

		//- (void) setLbtItemData:(NSArray*) lbtItemData;
		public void setLbtItemData(NSArray lbtItemData)
		{
            if (lbtItemData != null && lbtItemData.Count > 0)
            {
                NSData lbtData = NSKeyedArchiver.ArchivedDataWithRootObject(lbtItemData);
                m_userDefaults.SetValueForKey(lbtData, LBTITEMDATA);
                m_userDefaults.Synchronize();
            }
		}
		//- (NSArray*) getLbtItemData;
		public NSArray getLbtItemData()
		{
			NSData lbtData = m_userDefaults.DataForKey(LBTITEMDATA);
            if (lbtData != null)
            {

                NSArray array = (NSArray)NSKeyedUnarchiver.UnarchiveObject(lbtData);
                if (array != null)
                {
                    return array;
                }
            }
			return new NSArray();
        }
		//- (void) setEpcMaskData:(NSArray*) epcMaskData;
		public void setEpcMaskData(NSArray epcMaskData)
		{
            if (epcMaskData != null)
            {
                NSData epcData = NSKeyedArchiver.ArchivedDataWithRootObject(epcMaskData);
                m_userDefaults.SetValueForKey(epcData, EPCMASKDATA);
                m_userDefaults.Synchronize();
            }
		}
		//- (NSArray*) getEpcMaskData;
		public NSArray getEpcMaskData()
		{
            NSData tokenObject = m_userDefaults.DataForKey(EPCMASKDATA);
            if (tokenObject != null)
            {

                NSArray array = (NSArray)NSKeyedUnarchiver.UnarchiveObject(tokenObject);
                if (array != null)
                {
                    return array;
                }
            }
			return new NSArray();
        }
		//- (void) setSelectionEpcMaskData:(NSArray*) selectionEpcMaskData;
		public void setSelectionEpcMaskData(NSArray selectionEpcMaskData)
		{
            if (selectionEpcMaskData != null){

			    NSData selectionEpcData = NSKeyedArchiver.ArchivedDataWithRootObject(selectionEpcMaskData);
				m_userDefaults.SetValueForKey(selectionEpcData, SELECTIONEPCMASKDATA);
				m_userDefaults.Synchronize(); 
            }
		}
		//- (NSArray*) getSelectionEpcMaskData;
		public NSArray getSelectionEpcMaskData()
		{
			NSData tokenObject = m_userDefaults.DataForKey(SELECTIONEPCMASKDATA);
            if (tokenObject != null)
            {

                NSArray array = (NSArray)NSKeyedUnarchiver.UnarchiveObject(tokenObject);
                if (array != null)
                {
                    return array;
                }
            }
			return new NSArray();
        }
		//
		//- (void) setBarcodeParamData:(NSArray*) barcodeParamData;
		public void setBarcodeParamData(NSArray barcodeParamData)
		{
            if (barcodeParamData != null){
				NSData barcodeData = NSKeyedArchiver.ArchivedDataWithRootObject(barcodeParamData);
				m_userDefaults.SetValueForKey(barcodeData, BARCODEPARAMDATA);
				m_userDefaults.Synchronize(); 
            }
		}
		//- (NSArray*) getBarcodeParamData;
		public NSArray getBarcodeParamData()
		{
			NSData tokenObject = m_userDefaults.DataForKey(BARCODEPARAMDATA);
            if (tokenObject != null){
				NSArray array = (NSArray)NSKeyedUnarchiver.UnarchiveObject(tokenObject);
				if (array != null)
				{
					return array;
				}
            }
            return new NSArray();
		}
	}
}
