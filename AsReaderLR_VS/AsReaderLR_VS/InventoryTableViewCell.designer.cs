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
	[Register ("InventoryTableViewCell")]
	partial class InventoryTableViewCell
	{
		[Outlet]
        public UIKit.UILabel countLabel { get; set; }

		[Outlet]
        public UIKit.UILabel frequency { get; set; }

		[Outlet]
        public UIKit.UILabel phaseLabel { get; set; }

		[Outlet]
        public UIKit.UILabel rssiLabel { get; set; }

		[Outlet]
        public UIKit.UILabel tagLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tagLabel != null) {
				tagLabel.Dispose ();
				tagLabel = null;
			}

			if (countLabel != null) {
				countLabel.Dispose ();
				countLabel = null;
			}

			if (rssiLabel != null) {
				rssiLabel.Dispose ();
				rssiLabel = null;
			}

			if (phaseLabel != null) {
				phaseLabel.Dispose ();
				phaseLabel = null;
			}

			if (frequency != null) {
				frequency.Dispose ();
				frequency = null;
			}
		}
	}
}
