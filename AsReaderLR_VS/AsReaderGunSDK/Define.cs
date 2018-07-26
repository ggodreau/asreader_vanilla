using System;
using Foundation;
namespace AsReaderGunSDK
{
    public class Define
    {
        public int TAG_PC_LENGTH = 4;

        public int TAG_DATA_TYPE_ASCII = 0;
        public int TAG_DATA_TYPE_HEX = 1;
                
        public int BARCODE_NONE = 0;
        public int BARCODE_POWER = 1;
        public int BARCODE_AIM = 2;
        public int BARCODE_TRIGGER = 4;

        public int MIN_SELECTION_MASK = 0;
        public int MAX_SELECTION_MASK = 8;

        public int MAX_LBT = 50;
        public int BARCODE_MODULE_ENABLED = 0x08;

        public int VER_7_2_5_2 = 0x07020502;
        public int VER_5_2_2_28 = 0x0502021C;
        public int VER_6_0_0_00 = 0x06000000;
	    public int VERSION_MASK = 0x00FFFFFF;
	    public int VER_X_2_2_1 = 0x00020201;
        public int VER_X_2_2_6 = 0x00020206;
        public int VER_X_2_2_20 = 0x00020214;
	    public int VER_X_2_2_18 = 0x00020212;
        public int VER_X_2_2_28 = 0x0002021C;

		public int MAX_VERSION = 4;

        public NSString VERSION_PREFIX_RFPRISMA = new NSString("bl-");
		public NSString VERSION_PRIFIX_ASREADER = new NSString("ar-");


		private static Define uniqueInstance;

		private static readonly object locker = new object();

        public Define()
        {
        }

		public static Define sharedDefine()
		{
			if (uniqueInstance == null)
			{
				lock (locker)
				{
					if (uniqueInstance == null)
					{
                        uniqueInstance = new Define();
					}
				}
			}
			return uniqueInstance;
		}
    }
}
