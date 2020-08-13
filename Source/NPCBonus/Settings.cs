using System;
using UnityEngine;
using Verse;

namespace NPCBonus
{
	// Token: 0x02000005 RID: 5
	public class Settings : ModSettings
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000025EC File Offset: 0x000007EC
		public void DoWindowContents(Rect canvas)
		{
			Listing_Standard listing_Standard = new Listing_Standard();
			listing_Standard.ColumnWidth = canvas.width;
			listing_Standard.Begin(canvas);
			float num = 2f;
			listing_Standard.Gap(num);
			float max = 100f;
			float min = -10f;
			checked
			{
				listing_Standard.Label("NPCBonus.PreAppPct".Translate() + "  " + (int)Settings.PreAppPct, -1f, null);
				Settings.PreAppPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PreAppPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.PreWpnPct".Translate() + "  " + (int)Settings.PreWpnPct, -1f, null);
				Settings.PreWpnPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PreWpnPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.PreTchPct".Translate() + "  " + (int)Settings.PreTchPct, -1f, null);
				Settings.PreTchPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PreTchPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.AppPct".Translate() + "  " + (int)Settings.AppPct, -1f, null);
				Settings.AppPct = (float)((int)listing_Standard.Slider((float)((int)Settings.AppPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.WpnPct".Translate() + "  " + (int)Settings.WpnPct, -1f, null);
				Settings.WpnPct = (float)((int)listing_Standard.Slider((float)((int)Settings.WpnPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.TchPct".Translate() + "  " + (int)Settings.TchPct, -1f, null);
				Settings.TchPct = (float)((int)listing_Standard.Slider((float)((int)Settings.TchPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.PostAppPct".Translate() + "  " + (int)Settings.PostAppPct, -1f, null);
				Settings.PostAppPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PostAppPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.PostWpnPct".Translate() + "  " + (int)Settings.PostWpnPct, -1f, null);
				Settings.PostWpnPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PostWpnPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.Label("NPCBonus.PostTchPct".Translate() + "  " + (int)Settings.PostTchPct, -1f, null);
				Settings.PostTchPct = (float)((int)listing_Standard.Slider((float)((int)Settings.PostTchPct), min, max));
				listing_Standard.Gap(num);
				listing_Standard.CheckboxLabeled("NPCBonus.AffordWeapon".Translate(), ref Settings.AffordWeapon, null);
			}
			listing_Standard.Gap(num * 2f);
			Text.Font = GameFont.Tiny;
			listing_Standard.Label("          " + "NPCBonus.Tip".Translate(), -1f, null);
			Text.Font = GameFont.Small;
			listing_Standard.Gap(num);
			listing_Standard.End();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002978 File Offset: 0x00000B78
		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look<float>(ref Settings.PreAppPct, "PreAppPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.PreWpnPct, "PreWpnPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.PreTchPct, "PreTchPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.AppPct, "AppPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.WpnPct, "WpnPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.TchPct, "TchPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.PostAppPct, "PostAppPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.PostWpnPct, "PostWpnPct", 0f, false);
			Scribe_Values.Look<float>(ref Settings.PostTchPct, "PostTchPct", 0f, false);
			Scribe_Values.Look<bool>(ref Settings.AffordWeapon, "AffordWeapon", false, false);
		}

		// Token: 0x04000003 RID: 3
		public static float PreAppPct;

		// Token: 0x04000004 RID: 4
		public static float PreWpnPct;

		// Token: 0x04000005 RID: 5
		public static float PreTchPct;

		// Token: 0x04000006 RID: 6
		public static float AppPct;

		// Token: 0x04000007 RID: 7
		public static float WpnPct;

		// Token: 0x04000008 RID: 8
		public static float TchPct;

		// Token: 0x04000009 RID: 9
		public static float PostAppPct;

		// Token: 0x0400000A RID: 10
		public static float PostWpnPct;

		// Token: 0x0400000B RID: 11
		public static float PostTchPct;

		// Token: 0x0400000C RID: 12
		public static bool AffordWeapon;
	}
}
