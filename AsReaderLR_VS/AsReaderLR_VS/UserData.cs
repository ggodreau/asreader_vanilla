using System;
using Foundation;

namespace AsReaderLR_VS
{
    public class UserData:NSObject
    {
        public UserData()
        {
        }

        public static void setMaskType(int maskType)
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            prefs.SetInt(maskType,"maskType");
            prefs.Synchronize();
        }
        public static int getMaskType()
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            return (int)prefs.IntForKey("maskType");
        }
        public static void setBatteryInterval(string batteryInterval)
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            prefs.SetString(batteryInterval, "batteryInterval");
            prefs.Synchronize();
        }
        public static string getBatteryInterval()
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            string batteryInterval = prefs.StringForKey("batteryInterval");
            if (batteryInterval == null || batteryInterval == "")
            {
                batteryInterval = @"10000";
            }
            return batteryInterval;
        }
        public static void setIsUseKeyAction(bool isUseKeyAction)
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            prefs.SetBool(isUseKeyAction, "isUseKeyAction");
            prefs.Synchronize();
        }
        public static bool getIsUseKeyAction()
        {
            NSUserDefaults prefs = NSUserDefaults.StandardUserDefaults;
            return prefs.BoolForKey("isUseKeyAction");
        }
    }
}
