using HarmonyLib;
using ModLoader;
using ModLoader.Helpers;
using SFS.IO;

namespace SmartSASMod
{
    public class Main : Mod
    {
        public override string ModNameID => "smartsasmod";
        public override string DisplayName => "Smart SAS";
        public override string Author => "pixelgaming579";
        public override string MinimumGameVersionNecessary => "1.5.8";
        public override string ModVersion => "v1.4";
        public override string Description => "Adds a variety of control options for the stability assist system (SAS).";

        public static Mod mod;
        public static FolderPath modFolder;

        public override void Early_Load()
        {
            mod = this;
            modFolder = new FolderPath(ModFolder);
            new Harmony("smartsasmod").PatchAll();
        }

        public override void Load()
        {
            SettingsManager.Load();
            SceneHelper.OnWorldSceneLoaded += GUI.SpawnGUI;
        }
    }
}