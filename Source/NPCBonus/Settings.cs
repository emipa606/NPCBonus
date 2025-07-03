using UnityEngine;
using Verse;

namespace NPCBonus;

public class Settings : ModSettings
{
    public static float PreAppPct;

    public static float PreWpnPct;

    public static float PreTchPct;

    public static float AppPct;

    public static float WpnPct;

    public static float TchPct;

    public static float PostAppPct;

    public static float PostWpnPct;

    public static float PostTchPct;

    public static bool AffordWeapon;

    public static void DoWindowContents(Rect canvas)
    {
        var listingStandard = new Listing_Standard { ColumnWidth = canvas.width };
        listingStandard.Begin(canvas);
        const float gapSize = 2f;
        listingStandard.Gap(gapSize);
        const float max = 100f;
        const float min = -10f;
        checked
        {
            listingStandard.Label("NPCBonus.PreAppPct".Translate() + "  " + (int)PreAppPct);
            PreAppPct = (int)listingStandard.Slider((int)PreAppPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.PreWpnPct".Translate() + "  " + (int)PreWpnPct);
            PreWpnPct = (int)listingStandard.Slider((int)PreWpnPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.PreTchPct".Translate() + "  " + (int)PreTchPct);
            PreTchPct = (int)listingStandard.Slider((int)PreTchPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.AppPct".Translate() + "  " + (int)AppPct);
            AppPct = (int)listingStandard.Slider((int)AppPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.WpnPct".Translate() + "  " + (int)WpnPct);
            WpnPct = (int)listingStandard.Slider((int)WpnPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.TchPct".Translate() + "  " + (int)TchPct);
            TchPct = (int)listingStandard.Slider((int)TchPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.PostAppPct".Translate() + "  " + (int)PostAppPct);
            PostAppPct = (int)listingStandard.Slider((int)PostAppPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.PostWpnPct".Translate() + "  " + (int)PostWpnPct);
            PostWpnPct = (int)listingStandard.Slider((int)PostWpnPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.Label("NPCBonus.PostTchPct".Translate() + "  " + (int)PostTchPct);
            PostTchPct = (int)listingStandard.Slider((int)PostTchPct, min, max);
            listingStandard.Gap(gapSize);
            listingStandard.CheckboxLabeled("NPCBonus.AffordWeapon".Translate(), ref AffordWeapon);
        }

        listingStandard.Gap(gapSize * 2f);
        Text.Font = GameFont.Tiny;
        listingStandard.Label("          " + "NPCBonus.Tip".Translate());
        Text.Font = GameFont.Small;
        listingStandard.Gap(gapSize);
        if (Controller.CurrentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("NPCBonus.CurrentModVersion".Translate(Controller.CurrentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }

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