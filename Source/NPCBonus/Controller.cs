using Mlie;
using UnityEngine;
using Verse;

namespace NPCBonus;

public class Controller : Mod
{
    public static Settings Settings;
    public static string CurrentVersion;

    public Controller(ModContentPack content) : base(content)
    {
        Settings = GetSettings<Settings>();
        CurrentVersion =
            VersionFromManifest.GetVersionFromModMetaData(content.ModMetaData);
    }

    public override string SettingsCategory()
    {
        return "NPCBonus.Name".Translate();
    }

    public override void DoSettingsWindowContents(Rect canvas)
    {
        Settings.DoWindowContents(canvas);
    }
}