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
	[Register ("EpcMaskTableViewCell")]
	partial class EpcMaskTableViewCell
	{
		[Outlet]
        public UIKit.UILabel lengthLabel { get; set; }

		[Outlet]
        public UIKit.UILabel maskLabel { get; set; }

		[Outlet]
        public UIKit.UILabel offsetLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (offsetLabel != null) {
				offsetLabel.Dispose ();
				offsetLabel = null;
			}

			if (lengthLabel != null) {
				lengthLabel.Dispose ();
				lengthLabel = null;
			}

			if (maskLabel != null) {
				maskLabel.Dispose ();
				maskLabel = null;
			}
		}
	}
}
