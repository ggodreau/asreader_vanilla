// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AsReaderLR_VS
{
	[Register ("BarcodeDemoTableViewCell")]
	partial class BarcodeDemoTableViewCell
	{
		[Outlet]
        public UIKit.UILabel barcodeLabel { get; set; }

		[Outlet]
        public UIKit.UILabel codeIdLabel { get; set; }

		[Outlet]
        public UIKit.UILabel codeTypeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (codeTypeLabel != null) {
				codeTypeLabel.Dispose ();
				codeTypeLabel = null;
			}

			if (codeIdLabel != null) {
				codeIdLabel.Dispose ();
				codeIdLabel = null;
			}

			if (barcodeLabel != null) {
				barcodeLabel.Dispose ();
				barcodeLabel = null;
			}
		}
	}
}
