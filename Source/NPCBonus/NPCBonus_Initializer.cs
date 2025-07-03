using System;
using Verse;

namespace NPCBonus;

[StaticConstructorOnStartup]
internal static class NPCBonus_Initializer
{
    static NPCBonus_Initializer()
    {
        LongEventHandler.QueueLongEvent(setup, "LibraryStartup", false, null);
    }

    private static void setup()
    {
        var allDefsListForReading = DefDatabase<PawnKindDef>.AllDefsListForReading;
        if (allDefsListForReading.Count <= 0)
        {
            return;
        }

        var num = 0;
        var num2 = 0;
        var num3 = 0;
        foreach (var pawnKindDef in allDefsListForReading)
        {
            if (pawnKindDef?.defaultFactionDef == null ||
                pawnKindDef.defaultFactionDef.isPlayer || !NPCBonusUtility.GetAdjVal(
                    pawnKindDef.defaultFactionDef.techLevel, out var num4, out var num5,
                    out var num6))
            {
                continue;
            }

            if (num4 != 0f)
            {
                pawnKindDef.apparelMoney.min =
                    Math.Max(pawnKindDef.apparelMoney.min * ((num4 + 100f) / 100f), 0f);
                pawnKindDef.apparelMoney.max =
                    Math.Max(pawnKindDef.apparelMoney.max * ((num4 + 100f) / 100f), 0f);
                checked
                {
                    num++;
                }
            }

            if (num5 != 0f || Settings.AffordWeapon)
            {
                var num7 = 0f;
                var moneyMin = false;
                var moneyMax = false;
                if (Settings.AffordWeapon)
                {
                    num7 = NPCBonusUtility.GetMinWeaponValue(pawnKindDef);
                }

                var num8 = Math.Max(pawnKindDef.weaponMoney.min * ((num5 + 100f) / 100f), 0f);
                float num9;
                if (Settings.AffordWeapon)
                {
                    num9 = num7 >= num8 ? num7 : num8;
                }
                else
                {
                    num9 = num8;
                }

                if (num9 != pawnKindDef.weaponMoney.min)
                {
                    pawnKindDef.weaponMoney.min = num9;
                    moneyMin = true;
                }

                var num10 = Math.Max(pawnKindDef.weaponMoney.max * ((num5 + 100f) / 100f), 0f);
                float num11;
                if (Settings.AffordWeapon)
                {
                    num11 = num10 >= num9 ? num10 : num9;
                }
                else
                {
                    num11 = num10;
                }

                if (num11 != pawnKindDef.weaponMoney.max)
                {
                    pawnKindDef.weaponMoney.max = num11;
                    moneyMax = true;
                }

                checked
                {
                    if (moneyMin || moneyMax)
                    {
                        num2++;
                    }
                }
            }

            if (num6 == 0f)
            {
                continue;
            }

            pawnKindDef.techHediffsMoney.min =
                Math.Max(pawnKindDef.techHediffsMoney.min * ((num6 + 100f) / 100f), 0f);
            pawnKindDef.techHediffsMoney.max =
                Math.Max(pawnKindDef.techHediffsMoney.max * ((num6 + 100f) / 100f), 0f);
            checked
            {
                num3++;
            }
        }

        Log.Message("NPCBonus.Report".Translate(num.ToString(), num2.ToString(), num3.ToString()));
    }
}