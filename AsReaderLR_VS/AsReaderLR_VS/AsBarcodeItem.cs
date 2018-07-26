using AsReaderGunSDK;
using Foundation;
namespace AsReaderLR_VS
{
    public class AsBarcodeItem:NSObject
    {
        public string codeId;
        public string barcode;
        public string dateTime;
        public BarcodeType barcodeType;

        public AsBarcodeItem()
        {
        }
    }
}
