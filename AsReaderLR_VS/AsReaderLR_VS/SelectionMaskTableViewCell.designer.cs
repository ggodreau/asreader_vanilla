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
	[Register ("SelectionMaskTableViewCell")]
	partial class SelectionMaskTableViewCell
	{
		[Outlet]
        public UIKit.UILabel actionLabel { get; set; }

		[Outlet]
        public UIKit.UILabel bankLabel { get; set; }

		[Outlet]
        public UIKit.UILabel lengthLabel { get; set; }

		[Outlet]
        public UIKit.UILabel maskLabel { get; set; }

		[Outlet]
        public UIKit.UILabel offsetLabel { get; set; }

		[Outlet]
        public UIKit.UILabel targetLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (targetLabel != null) {
				targetLabel.Dispose ();
				targetLabel = null;
			}

			if (bankLabel != null) {
				bankLabel.Dispose ();
				bankLabel = null;
			}

			if (actionLabel != null) {
				actionLabel.Dispose ();
				actionLabel = null;
			}

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
