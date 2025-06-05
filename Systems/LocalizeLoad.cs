#pragma warning disable CA2255
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Core;
using static Terraria.ModLoader.Core.TmodFile;
using static ThoriumModzhcn.Systems.LocalizeUtil;

namespace ThoriumModzhcn.Systems
{
    public class LocalizeLoad : ModSystem
    {
        /*public static List<string> PCRHJson { get; } =
         [
            "Localization/zh-Potralia/zh-Potralia.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.CalamityBardHealer.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.SOTSBardHealer.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.SpiritBardHealer.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.SpookyBardHealer.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.TerrariumHacks.hjson",
            "Localization/zh-Potralia/zh-Potralia_Mods.ThoriumRework.hjson",
            "ZHhjson/Potraliazh/IL_ThoriumModpcr.hjson",
            "ZHhjson/Potraliazh/IL_CalamityBardHealerpcr.hjson",
            "ZHhjson/Potraliazh/IL_ThoriumClassTagsConsistencypcr.hjson",
            "ZHhjson/Potraliazh/IL_SpookyBardHealerpcr.hjson",
        ];

        public static List<string> CSOWHJson { get; } =
         [
            "Localization/zh-CSOW/zh-CSOW.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.CalamityBardHealer.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.SOTSBardHealer.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.SpiritBardHealer.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.SpookyBardHealer.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.TerrariumHacks.hjson",
            "Localization/zh-CSOW/zh-CSOW_Mods.ThoriumRework.hjson",
            "ZHhjson/Csowzh/IL_ThoriumModcsow.hjson",
            "ZHhjson/Csowzh/IL_CalamityBardHealercsow.hjson",
            "ZHhjson/Csowzh/IL_ThoriumClassTagsConsistencycsow.hjson",
            "ZHhjson/Csowzh/IL_SpookyBardHealercsow.hjson",
        ];*/

        public static List<string> TWHJson { get; } =
         [
            "Localization/zh-TW/zh-tw.hjson",
            "Localization/zh-TW/zh-tw_Mods.CalamityBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SOTSBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SpiritBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.SpookyBardHealer.hjson",
            "Localization/zh-TW/zh-tw_Mods.TerrariumHacks.hjson",
            "Localization/zh-TW/zh-tw_Mods.ThoriumRework.hjson",
            "ZHhjson/Unsimplifiedzh/IL_ThoriumModtw.hjson",
            "ZHhjson/Unsimplifiedzh/IL_CalamityBardHealertw.hjson",
            "ZHhjson/Unsimplifiedzh/IL_ThoriumClassTagsConsistencytw.hjson",
            "ZHhjson/Unsimplifiedzh/IL_SpookyBardHealertw.hjson",
        ];

        public static List<string> ZHHJson { get; } = 
        [
            "Localization/zh-Hans/zh-Hans.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.CalamityBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.RedemptionBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SOTSBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SpiritBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.SpookyBardHealer.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.TerrariumHacks.hjson",
            "Localization/zh-Hans/zh-Hans_Mods.ThoriumRework.hjson",
            "ZHhjson/Simplifiedzh/IL_ThoriumModzh.hjson",
            "ZHhjson/Simplifiedzh/IL_CalamityBardHealerzh.hjson",
            "ZHhjson/Simplifiedzh/IL_ThoriumClassTagsConsistencyzh.hjson",
            "ZHhjson/Simplifiedzh/IL_SpookyBardHealerzh.hjson",
        ];


        [ModuleInitializer]
        public static void LoadLocalizationJson()
        {
            Load(ZHHJson, Language.简体中文);
        }

        private static void Load(List<string> paths, Language language)
        {
            foreach (var hjson in paths) 
                LoadLocalizedKey(hjson, language, GetStartChars(hjson));
        }

        public override void PostSetupRecipes()
        {
            //LoadFatherKey(Language.Potralia的害人汉化);
            LoadFatherKey(Language.台湾繁体);
            LoadFatherKey(Language.简体中文);
            //LoadFatherKey(Language.文言文汉化);
            base.PostSetupRecipes();
        }

        private static void LoadFatherKey(Language language)
        {
            Dictionary<string, string> localizeTests = GetLocalizationDictionary(language);
            string regex = @"\{\$(.*?)\}";
            foreach (var kv in localizeTests) {

                MatchCollection matchs = Regex.Matches(kv.Value, regex);
                //调试代码
                //if (kv.Value.Contains("发光的野兽在泰拉大陆的地底梭巡,把沿途搅得一团糟。{$NPCs.GildedBat.DisplayName},{$NPCs.GildedLycan.DisplayName}和{$NPCs.GildedSlime.DisplayName}会发光,它们看着相当显眼。这些生物的数量应该尽可能少,能少一点是一点。")) {
                //    int a = 1;
                //}

                foreach (Match item in matchs) {
                    string @waibu = item.Groups[0].Value; //0是原始值(${NPC.Tim})，1是内部值(NPC.Tim)
                    string @neibu = item.Groups[1].Value;
                    string[] start = kv.Key.Split(".");
                    string keyStart = start[0] + "." + start[1] + "."; //Key的开头
                    string key = keyStart + neibu;       //父字符串的本地化Key
                    if (localizeTests.TryGetValue(key, out string frstring)) {//父字符串({$})的值
                        localizeTests[kv.Key] = localizeTests[kv.Key].Replace(waibu, frstring);
                    } else if (LocalizedTexts.TryGetValue(neibu, out var vstring)) {
                        localizeTests[kv.Key] = localizeTests[kv.Key].Replace(waibu, vstring.Value);
                    }
                }
            }

        }

        private static string GetStartChars(string fileName)
        {
            var splitString = fileName.Split("_");
            if (splitString.Length == 1) return "";
            //if (splitString[0] == "IL") return "";
            if (fileName.Contains("IL_")) return "";
            return splitString[1].Replace(".hjson", ".");
        }

        public static Language CurrentLanguage { get; set; } = Language.简体中文;
    }

    public class 语言切换 : ModConfig
    {
        public Language 语言;

        public override ConfigScope Mode => ConfigScope.ClientSide;

        public override void OnChanged()
        {
            LocalizeLoad.CurrentLanguage = 语言;
            CutLanguage(语言);
            base.OnChanged();
        }
    }
}
