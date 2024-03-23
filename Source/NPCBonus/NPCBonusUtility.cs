using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace NPCBonus;

public class NPCBonusUtility
{
    private static List<ThingStuffPair> allWeaponPairs = [];

    public static float GetMinWeaponValue(PawnKindDef PKD)
    {
        var min = PKD.weaponMoney.min;
        var num = PKD.weaponMoney.max;
        if (PKD.weaponTags == null || PKD.weaponTags.Count == 0)
        {
            return min;
        }

        var list = allWeaponPairs.Count > 0 ? allWeaponPairs : ThingStuffPair.AllWith(t => t.IsWeapon);

        if (list.Count > 0)
        {
            allWeaponPairs = list;
        }

        if (PKD.defaultFactionType == null)
        {
            return min;
        }

        var minCompareTechLevel = GetMinCompareTechLevel(PKD.defaultFactionType.techLevel);
        if (GetAdjVal(minCompareTechLevel, out _, out var num4, out _) && num4 != 0f)
        {
            num = Math.Max(num * ((num4 + 100f) / 100f), 0f);
        }

        if (!(num > 0f))
        {
            return min;
        }

        var num2 = num;
        foreach (var thingStuffPair in allWeaponPairs)
        {
            if (thingStuffPair.thing.techLevel == minCompareTechLevel && num2 > thingStuffPair.Price)
            {
                num2 = thingStuffPair.Price;
            }
        }

        if (num2 <= num && num2 > min)
        {
            return num2;
        }

        return min;
    }

    private static TechLevel GetMinCompareTechLevel(TechLevel TL)
    {
        if (TL == TechLevel.Neolithic || TL == TechLevel.Medieval)
        {
            return TechLevel.Neolithic;
        }

        if (TL == TechLevel.Industrial)
        {
            return TechLevel.Industrial;
        }

        if (TL == TechLevel.Spacer || TL == TechLevel.Ultra || TL == TechLevel.Archotech)
        {
            return TechLevel.Spacer;
        }

        return TechLevel.Neolithic;
    }

    internal static bool GetAdjVal(TechLevel tech, out float app, out float wpn, out float tch)
    {
        var result = false;
        app = wpn = tch = 0f;
        switch (tech)
        {
            case TechLevel.Neolithic:
                result = true;
                app = Settings.PreAppPct;
                wpn = Settings.PreWpnPct;
                tch = Settings.PreTchPct;
                break;
            case TechLevel.Medieval:
                result = true;
                app = Settings.PreAppPct;
                wpn = Settings.PreWpnPct;
                tch = Settings.PreTchPct;
                break;
            case TechLevel.Industrial:
                result = true;
                app = Settings.AppPct;
                wpn = Settings.WpnPct;
                tch = Settings.TchPct;
                break;
            case TechLevel.Spacer:
                result = true;
                app = Settings.PostAppPct;
                wpn = Settings.PostWpnPct;
                tch = Settings.PostTchPct;
                break;
            case TechLevel.Ultra:
                result = true;
                app = Settings.PostAppPct;
                wpn = Settings.PostWpnPct;
                tch = Settings.PostTchPct;
                break;
            case TechLevel.Archotech:
                result = true;
                app = Settings.PostAppPct;
                wpn = Settings.PostWpnPct;
                tch = Settings.PostTchPct;
                break;
        }

        return result;
    }
}