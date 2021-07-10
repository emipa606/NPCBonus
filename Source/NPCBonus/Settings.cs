using UnityEngine;
using Verse;

namespace NPCBonus
{
    // Token: 0x02000005 RID: 5
    public class Settings : ModSettings
    {
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

        // Token: 0x0600000B RID: 11 RVA: 0x000025EC File Offset: 0x000007EC
        public void DoWindowContents(Rect canvas)
        {
            var listing_Standard = new Listing_Standard {ColumnWidth = canvas.width};
            listing_Standard.Begin(canvas);
            var num = 2f;
            listing_Standard.Gap(num);
            var max = 100f;
            var min = -10f;
            checked
            {
                listing_Standard.Label("NPCBonus.PreAppPct".Translate() + "  " + (int) PreAppPct);
                PreAppPct = (int) listing_Standard.Slider((int) PreAppPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.PreWpnPct".Translate() + "  " + (int) PreWpnPct);
                PreWpnPct = (int) listing_Standard.Slider((int) PreWpnPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.PreTchPct".Translate() + "  " + (int) PreTchPct);
                PreTchPct = (int) listing_Standard.Slider((int) PreTchPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.AppPct".Translate() + "  " + (int) AppPct);
                AppPct = (int) listing_Standard.Slider((int) AppPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.WpnPct".Translate() + "  " + (int) WpnPct);
                WpnPct = (int) listing_Standard.Slider((int) WpnPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.TchPct".Translate() + "  " + (int) TchPct);
                TchPct = (int) listing_Standard.Slider((int) TchPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.PostAppPct".Translate() + "  " + (int) PostAppPct);
                PostAppPct = (int) listing_Standard.Slider((int) PostAppPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.PostWpnPct".Translate() + "  " + (int) PostWpnPct);
                PostWpnPct = (int) listing_Standard.Slider((int) PostWpnPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.Label("NPCBonus.PostTchPct".Translate() + "  " + (int) PostTchPct);
                PostTchPct = (int) listing_Standard.Slider((int) PostTchPct, min, max);
                listing_Standard.Gap(num);
                listing_Standard.CheckboxLabeled("NPCBonus.AffordWeapon".Translate(), ref AffordWeapon);
            }

            listing_Standard.Gap(num * 2f);
            Text.Font = GameFont.Tiny;
            listing_Standard.Label("          " + "NPCBonus.Tip".Translate());
            Text.Font = GameFont.Small;
            listing_Standard.Gap(num);
            listing_Standard.End();
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002978 File Offset: 0x00000B78
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref PreAppPct, "PreAppPct");
            Scribe_Values.Look(ref PreWpnPct, "PreWpnPct");
            Scribe_Values.Look(ref PreTchPct, "PreTchPct");
            Scribe_Values.Look(ref AppPct, "AppPct");
            Scribe_Values.Look(ref WpnPct, "WpnPct");
            Scribe_Values.Look(ref TchPct, "TchPct");
            Scribe_Values.Look(ref PostAppPct, "PostAppPct");
            Scribe_Values.Look(ref PostWpnPct, "PostWpnPct");
            Scribe_Values.Look(ref PostTchPct, "PostTchPct");
            Scribe_Values.Look(ref AffordWeapon, "AffordWeapon");
        }
    }
}