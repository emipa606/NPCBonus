using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace NPCBonus
{
	// Token: 0x02000003 RID: 3
	public class NPCBonusUtility
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		public static float GetMinWeaponValue(PawnKindDef PKD)
		{
			float min = PKD.weaponMoney.min;
			float num = PKD.weaponMoney.max;
			if (((PKD != null) ? PKD.weaponTags : null) == null || (PKD != null && PKD.weaponTags.Count == 0))
			{
				return min;
			}
			List<ThingStuffPair> list = new List<ThingStuffPair>();
			if (NPCBonusUtility.allWeaponPairs.Count > 0)
			{
				list = NPCBonusUtility.allWeaponPairs;
			}
			else
			{
				list = ThingStuffPair.AllWith((ThingDef t) => t.IsWeapon);
			}
			if (list.Count > 0)
			{
				NPCBonusUtility.allWeaponPairs = list;
			}
			if (((PKD != null) ? PKD.defaultFactionType : null) != null)
			{
				TechLevel minCompareTechLevel = NPCBonusUtility.GetMinCompareTechLevel(PKD.defaultFactionType.techLevel);
				float num2 = 999999f;
				float num3;
				float num4;
				float num5;
				if (NPCBonusUtility.GetAdjVal(minCompareTechLevel, out num3, out num4, out num5) && num4 != 0f)
				{
					num = Math.Max(num * ((num4 + 100f) / 100f), 0f);
				}
				if (num > 0f)
				{
					num2 = num;
					foreach (ThingStuffPair thingStuffPair in NPCBonusUtility.allWeaponPairs)
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
				}
			}
			return min;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021F0 File Offset: 0x000003F0
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

		// Token: 0x06000006 RID: 6 RVA: 0x00002214 File Offset: 0x00000414
		internal static bool GetAdjVal(TechLevel tech, out float app, out float wpn, out float tch)
		{
			bool result = false;
			app = (wpn = (tch = 0f));
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

		// Token: 0x04000002 RID: 2
		private static List<ThingStuffPair> allWeaponPairs = new List<ThingStuffPair>();
	}
}
