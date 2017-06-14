using System;

using UnityEngine;
using Verse;

namespace ResearchPal
{
    public class Settings : ModSettings
    {
        #region tuning parameters

        public const int     LineMaxLengthNodes = 20;
        public const int     MinTrunkSize       = 2;

		public static bool   showNotification   = true;

        #endregion tuning parameters

        #region UI elements

        public const float   HubSize            = 16f;
        public const int     TipID              = 24 * 1271;

		public static readonly Vector2 IconSize = new Vector2 (18f, 18f);
		public static readonly Vector2 NodeMargins = new Vector2 (50f, 10f);
		public static readonly Vector2 NodeSize = new Vector2 (200f, 50f);

        #endregion UI elements

		public static void DoSettingsWindowContents (Rect rect)
		{
			Listing_Standard list = new Listing_Standard (GameFont.Small);
			list.ColumnWidth = rect.width;
			list.Begin (rect);

			list.CheckboxLabeled ("ResearchPal.ShowNotificationPopup".Translate (), ref showNotification,
								  "ResearchPal.ShowNotificationTip".Translate ());

			list.End ();
		}

		public override void ExposeData ()
		{
			base.ExposeData ();
			Scribe_Values.Look (ref showNotification, "ShowNotificationPopup", true);
		}
    }
}