using System;
using System.Collections.Generic;
using Verse;

namespace NPCBonus
{
	// Token: 0x02000004 RID: 4
	[StaticConstructorOnStartup]
	internal static class NPCBonus_Initializer
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002302 File Offset: 0x00000502
		static NPCBonus_Initializer()
		{
			LongEventHandler.QueueLongEvent(new Action(NPCBonus_Initializer.Setup), "LibraryStartup", false, null, true);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002320 File Offset: 0x00000520
		public static void Setup()
		{
			List<PawnKindDef> allDefsListForReading = DefDatabase<PawnKindDef>.AllDefsListForReading;
			if (allDefsListForReading.Count > 0)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				foreach (PawnKindDef pawnKindDef in allDefsListForReading)
				{
					float num4;
					float num5;
					float num6;
					if (((pawnKindDef != null) ? pawnKindDef.defaultFactionType : null) != null && !pawnKindDef.defaultFactionType.isPlayer && NPCBonusUtility.GetAdjVal(pawnKindDef.defaultFactionType.techLevel, out num4, out num5, out num6))
					{
						if (num4 != 0f)
						{
							pawnKindDef.apparelMoney.min = Math.Max(pawnKindDef.apparelMoney.min * ((num4 + 100f) / 100f), 0f);
							pawnKindDef.apparelMoney.max = Math.Max(pawnKindDef.apparelMoney.max * ((num4 + 100f) / 100f), 0f);
							checked
							{
								num++;
							}
						}
						if (num5 != 0f || Settings.AffordWeapon)
						{
							float num7 = 0f;
							bool flag = false;
							bool flag2 = false;
							if (Settings.AffordWeapon)
							{
								num7 = NPCBonusUtility.GetMinWeaponValue(pawnKindDef);
							}
							float num8 = Math.Max(pawnKindDef.weaponMoney.min * ((num5 + 100f) / 100f), 0f);
							float num9;
							if (Settings.AffordWeapon)
							{
								num9 = ((num7 >= num8) ? num7 : num8);
							}
							else
							{
								num9 = num8;
							}
							if (num9 != pawnKindDef.weaponMoney.min)
							{
								pawnKindDef.weaponMoney.min = num9;
								flag = true;
							}
							float num10 = Math.Max(pawnKindDef.weaponMoney.max * ((num5 + 100f) / 100f), 0f);
							float num11;
							if (Settings.AffordWeapon)
							{
								num11 = ((num10 >= num9) ? num10 : num9);
							}
							else
							{
								num11 = num10;
							}
							if (num11 != pawnKindDef.weaponMoney.max)
							{
								pawnKindDef.weaponMoney.max = num11;
								flag2 = true;
							}
							checked
							{
								if (flag || flag2)
								{
									num2++;
								}
							}
						}
						if (num6 != 0f)
						{
							pawnKindDef.techHediffsMoney.min = Math.Max(pawnKindDef.techHediffsMoney.min * ((num6 + 100f) / 100f), 0f);
							pawnKindDef.techHediffsMoney.max = Math.Max(pawnKindDef.techHediffsMoney.max * ((num6 + 100f) / 100f), 0f);
							checked
							{
								num3++;
							}
						}
					}
				}
				Log.Message("NPCBonus.Report".Translate(num.ToString(), num2.ToString(), num3.ToString()), false);
			}
		}
	}
}
