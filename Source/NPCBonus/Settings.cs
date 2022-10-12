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

    public void DoWindowContents(Rect canvas)
    {
        var listing_Standard = new Listing_Standard { ColumnWidth = canvas.width };
        listing_Standard.Begin(canvas);
        var num = 2f;
        listing_Standard.Gap(num);
        var max = 100f;
        var min = -10f;
        checked
        {
            listing_Standard.Label("NPCBonus.PreAppPct".Translate() + "  " + (int)PreAppPct);
            PreAppPct = (int)listing_Standard.Slider((int)PreAppPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.PreWpnPct".Translate() + "  " + (int)PreWpnPct);
            PreWpnPct = (int)listing_Standard.Slider((int)PreWpnPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.PreTchPct".Translate() + "  " + (int)PreTchPct);
            PreTchPct = (int)listing_Standard.Slider((int)PreTchPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.AppPct".Translate() + "  " + (int)AppPct);
            AppPct = (int)listing_Standard.Slider((int)AppPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.WpnPct".Translate() + "  " + (int)WpnPct);
            WpnPct = (int)listing_Standard.Slider((int)WpnPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.TchPct".Translate() + "  " + (int)TchPct);
            TchPct = (int)listing_Standard.Slider((int)TchPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.PostAppPct".Translate() + "  " + (int)PostAppPct);
            PostAppPct = (int)listing_Standard.Slider((int)PostAppPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.PostWpnPct".Translate() + "  " + (int)PostWpnPct);
            PostWpnPct = (int)listing_Standard.Slider((int)PostWpnPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.Label("NPCBonus.PostTchPct".Translate() + "  " + (int)PostTchPct);
            PostTchPct = (int)listing_Standard.Slider((int)PostTchPct, min, max);
            listing_Standard.Gap(num);
            listing_Standard.CheckboxLabeled("NPCBonus.AffordWeapon".Translate(), ref AffordWeapon);
        }

        listing_Standard.Gap(num * 2f);
        Text.Font = GameFont.Tiny;
        listing_Standard.Label("          " + "NPCBonus.Tip".Translate());
        Text.Font = GameFont.Small;
        listing_Standard.Gap(num);
        if (Controller.currentVersion != null)
        {
            listing_Standard.Gap();
            GUI.contentColor = Color.gray;
            listing_Standard.Label("NPCBonus.CurrentModVersion".Translate(Controller.currentVersion));
            GUI.contentColor = Color.white;
        }

        listing_Standard.End();
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