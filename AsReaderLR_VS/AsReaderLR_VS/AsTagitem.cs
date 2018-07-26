using System;
using Foundation;

namespace AsReaderLR_VS
{
    public class AsTagitem:NSObject
    {
        public string tag;
        public int count;
        public float rssi;
        public float phase;
        public float frequency;
        public string dateTime;

        public static AsTagitem itemWith(string _tag, float _rssi, float _phase, float _frequency)
        {
            AsTagitem item = new AsTagitem();
            item.tag = _tag;
            item.rssi = _rssi;
            item.phase = _phase;
            item.frequency = _frequency;
            item.count = 1;
            NSDate timeDate = NSDate.Now;
            NSDateFormatter formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.Medium;
            formatter.TimeStyle = NSDateFormatterStyle.Short;
            formatter.DateFormat = "YYYY/MM/dd HH:mm:ss";
            item.dateTime = formatter.ToString(timeDate);
            return item;
        }

        public void updateRssi(float _rssi, float _phase, float _frequency)
        {
            NSDate timeDate = NSDate.Now;
            NSDateFormatter formatter = new NSDateFormatter();
            formatter.DateStyle = NSDateFormatterStyle.Medium;
            formatter.TimeStyle = NSDateFormatterStyle.Short;
            formatter.DateFormat = "YYYY/MM/dd HH:mm:ss";
            dateTime = formatter.ToString(timeDate);
            rssi = _rssi;
            phase = _phase;
            frequency = _frequency;
        }
    }
}
