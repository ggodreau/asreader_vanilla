using Foundation;
using UIKit;
using AsReaderGunSDK;
using System;
using MBProgressHud;
using System.Collections.Generic;
using CoreAnimation;

namespace AsReaderLR_VS
{

    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.


    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        int PRINT_LOG = 0;
        public int kBluetoothAlertView = 0;
        public int kDeviceAlertView = 1;
        public int VersionAlertView = 2;
        public int VersionForceAlertView = 3;

        public string[] DATA_TARGET = { "S0", "S1", "S2", "S3", "SL" };
        public string[] DATA_ACTION = { "AB", "AN", "NB", "MN", "BA", "BN", "NA", "NM" };
        public string[] DATA_BANK = { "Reserved", "EPC", "TID", "User" };
        public string[] DATA_BIT = { "0", "16", "32", "48", "64", "80", "96", "112", "128", "144", "160", "176", "192", "208", "224", "240" };
        public string[] DATA_WORD = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        public string[] DATA_SELECT_FLAG = { "SL", "~SL", "All" };
        public string[] DATA_INVENTORY_SESSION = { "S0", "S1", "S2", "S3" };
        public string[] DATA_SESSION_FLAG = { "A Only", "B Only", "A or B" };

        public int MAX_PASSWORD_LENGTH = 8;
        public int MAX_WRITE_DATA_WORD = 32;
        public int MAX_WRITE_DATA_LENGTH = 32 * 4;

        public List<AsBarcodeItem> barcodeData = new List<AsBarcodeItem>();
		public List<AsTagitem> rfidData = new List<AsTagitem>();

        public NSMutableDictionary mapTags = new NSMutableDictionary();

        SystemSetting systemSetting;

        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            systemSetting = SystemSetting.sharedSystemSetting();
            if (!systemSetting.getFirstUsed())
            {
                systemSetting.setFirstUser(true);
                systemSetting.setBuzzer((int)BuzzerState.High);
                systemSetting.setVibrator((int)VibratorState.n);
                systemSetting.setInventoryTime(400);
                systemSetting.setIdleTime(0);
                systemSetting.setAutoOffTime(1800);
                systemSetting.setQValue(4);
                systemSetting.setAlgorithm((int)AlgorithmType.DynamicQ);
                systemSetting.setMaxQ(15);
                systemSetting.setMinQ(0);
                systemSetting.setSleepTime(300);
                systemSetting.setMaskTypeValue((int)MaskType.NoMask);
                systemSetting.setLinkProfileValue(1);
                systemSetting.setDefaultLinkProfileValue(1);
                systemSetting.setOperationTime(0);
                systemSetting.setPowerGain(300);
                systemSetting.setInventorySession((int)SessionType.Session_S0);
                systemSetting.setSessionFlag(SessionFlag.Ab);
                systemSetting.setContinuousMode(true);
                systemSetting.setRssiMode(false);
                systemSetting.setPropBarcodeMode(true);
                systemSetting.setEpcMaskMatchMode(false);
                systemSetting.setDisPlayPC(true);
                systemSetting.setLbtItemData(null);
                systemSetting.setEpcMaskData(null);
                systemSetting.setUseSelectionMask(SelectFlag.All);
                systemSetting.setSelectionEpcMaskData(null);
                systemSetting.setBarcodeParamData(null);
                systemSetting.setBuzzerTime(1);
                systemSetting.setVibratorTime(1);
                systemSetting.setBarcodeReScanTime(0);
            }

	//[UIApplication redirectConsoleLogToDocumentFolder:@"log.txt"];
    //[AsRingDeviceSDK sharedAsRingDeviceSDK];
    //[self removeLogFile];
    //[self redirectNSLogToDocumentFolder];
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }

        #pragma mark - Utility Methods
        public string getAppVersion()
		{
            NSDictionary infoDictionary = NSBundle.MainBundle.InfoDictionary;
            NSString majorVersion = (NSString)infoDictionary.ObjectForKey(new NSString("CFBundleShortVersionString"));
			NSString minorVersion = (NSString)infoDictionary.ObjectForKey(new NSString("CFBundleVersion"));
            return "Version "+majorVersion.ToString()+" Build " + minorVersion.ToString();
		}

        public UIViewController getCurrentVC()
        {
            UIViewController result = null;
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            if (window.WindowLevel == UIWindowLevel.Normal)
            {
                Array windows = UIApplication.SharedApplication.Windows;
                foreach (UIWindow tmpWin in windows)
                {
					if (tmpWin.WindowLevel == UIWindowLevel.Normal)
					{
						window = tmpWin;
						break;
					}
                }

            }
            UIView frontView = window.Subviews[0];
            var nextResponder = frontView.NextResponder;
            UIViewController controller = new UIViewController();
            if (nextResponder.Class == controller.Class)
                result = (UIViewController)nextResponder;
            else
                result = window.RootViewController;
            return result;
        }
        public static void showGlobalProgressHUDWithTitle(string title)
        {
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            MBProgressHUD hud = MBProgressHUD.ShowHUDAddedTo(window, true);
            hud.LabelText = title;
            CATransaction.Commit();
        }
        public static void dismissGlobalHUD()
        {
            UIWindow window = UIApplication.SharedApplication.KeyWindow;
            MBProgressHUD.HideAllHUDsForView(window, true);
            CATransaction.Commit();
        }
	}
}