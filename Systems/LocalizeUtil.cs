﻿#nullable enable
using Hjson;
using Microsoft.Xna.Framework;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems
{
    public class LocalizeUtil : ModSystem
    {
        private static TmodFile? thisTModFile;
        /// <summary>
        /// 本模组的模组文件
        /// </summary>
        public static TmodFile ThisTModFile { 
            get
            {
                if (thisTModFile is null) {
                    LoadModAssembly.LoadModContext.TryGetValue(
                        typeof(LocalizeLoad).FullName!.Split('.')[0],
                        out var modContext
                    );
                    thisTModFile = (TmodFile)modContext!.GetType().GetField("modFile")!.GetValue(modContext)!;
                }
                return thisTModFile!;
            }
        }
        private static Dictionary<string, string> 台湾繁体 { get; } = [];
        private static Dictionary<string, string> Potralia的害人汉化 { get; } = [];
        private static Dictionary<string, string> 简体中文 { get; } = [];
        private static Dictionary<string, string> 文言文汉化 { get; } = [];
        //private static Dictionary<string, LocalizedText> TaiWan { get; } = [];
        //private static Dictionary<string, LocalizedText> HongKong { get; } = [];
        //private static Dictionary<string, LocalizedText> Chinese { get; } = [];


        private static MethodInfo? localizedTextSetValue;
        /// <summary>
        /// 设置LocalizedText值的方法
        /// </summary>
        public static MethodInfo LocalizedTextSetValue { 
            get
            {
                return localizedTextSetValue ??= 
                    typeof(LocalizedText)
                        .GetProperty(nameof(LocalizedText.Value))!
                        .GetSetMethod(true)!;
            }
        }

        internal static Dictionary<string, LocalizedText>? localizedTexts;
        /// <summary>
        /// 全部本地化键和值
        /// </summary>
        public static Dictionary<string, LocalizedText> LocalizedTexts 
        {
            get
            {
                return localizedTexts ??=
                    (Dictionary<string, LocalizedText>)typeof(LanguageManager)!
                        .GetField("_localizedTexts", BindingFlags.NonPublic | BindingFlags.Instance)!
                        .GetValue(LanguageManager.Instance)!;
            }
        }

        /// <summary>
        /// LocalizedText的构造方法(私有的)
        /// </summary>
        private readonly static ConstructorInfo LocalizedTextCons = typeof(LocalizedText).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, [typeof(string), typeof(string)])!;

        /// <summary>
        /// 创建一个LocalizedText，其构造方法是私有的
        /// </summary>
        public static LocalizedText CreateLocalizedText(string Key, string Value)
        {
            return (LocalizedText)LocalizedTextCons.Invoke([Key, Value]);
        }

        /// <summary>
        /// 一步到位 传入文件名称,返回键值
        /// <para>例: zh-tw_Mods.LocalText.hjson</para>
        /// </summary>
        public static List<(string, string)> OneStepToGo(string fileName, string startChar = "") => Method(GetText(fileName), startChar, fileName);

        /// <summary>
        /// 加载文件键值到字典
        /// </summary>
        public static void LoadLocalizedKey(string fileName, Language language, string startChar = "")
        {
            Dictionary<string, string> keyValue;
            //Dictionary<string, LocalizedText> keyValue;
            keyValue = GetLocalizationDictionary(language);
            if (keyValue == null) return;
            foreach (var item in OneStepToGo(fileName, startChar)) {
                if (!keyValue.ContainsKey(item.Item1)) {
                    keyValue.Add(item.Item1, /*CreateLocalizedText(item.Item1, item.Item2)*/item.Item2);
                    if (!LocalizedTexts.ContainsKey(item.Item1))
                        LocalizedTexts.Add(item.Item1, CreateLocalizedText(item.Item1, item.Item2));
                }
            }
        }

        /// <summary>
        /// 转换到目标语言
        /// </summary>
        public static void CutLanguage(Language language)
        {
            switch (language) {
                case Language.台湾繁体:
                    GoToDictionary(台湾繁体);
                    break;
                //case Language.Potralia的害人汉化:
                    //GoToDictionary(Potralia的害人汉化);
                    //break;
                case Language.简体中文:
                    GoToChinese();
                    GoToDictionary(简体中文);
                    break;
                //case Language.文言文汉化:
                    //GoToChinese();
                    //GoToDictionary(文言文汉化);
                    //break;
            }
        }

        /// <summary>
        /// 将现在使用的本地化值切换为传入字典的值
        /// </summary>
        //private static void GoToDictionary(Dictionary<string, LocalizedText> localizedTexts)
        private static void GoToDictionary(Dictionary<string, string> localizedTexts)
        {
            //CombatText.NewText(new Rectangle(Main.player[Main.myPlayer]));
            Main.NewText("正在更改文本内容");
            foreach (var kv in localizedTexts) {
                var localizedText = LanguageManager.Instance.GetText(kv.Key);
                LocalizedTextSetValue.Invoke(localizedText, [kv.Value]);
                //if (LocalizedTexts.ContainsKey(kv.Key)) {
                //    //LocalizedTexts[kv.Key] = kv.Value;
                //    var xg = LocalizedTexts[kv.Key];
                //    LocalizedTextSetValue.Invoke(xg, [kv.Value]);
                //}
            }
            Main.NewText("文本内容更改完成");
        }

        /// <summary>
        /// 恢复为中文(只适用于原生Hjson)
        /// </summary>
        private static void GoToChinese()
        {
            //LocalizationLoader.LoadModTranslations(new GameCulture("zh-Hans", 7));
        }

        /// <summary>
        /// 获取语言对应的字典
        /// </summary>
        //private static Dictionary<string, LocalizedText> GetLocalizationDictionary(Language language)
        public static Dictionary<string, string> GetLocalizationDictionary(Language language)
        {
            if (language == Language.台湾繁体)
                return 台湾繁体;
            //else if (language == Language.Potralia的害人汉化)
                //return Potralia的害人汉化;
            //else if (language == Language.文言文汉化)
                //return 文言文汉化;
            else
                return 简体中文;
        }

        /// <summary>
        /// 传入模组内文件夹名称,返回此文件的内容
        /// <para> 例: zh-tw_Mods.LocalText.hjson </para>
        /// </summary>
        private static string GetText(string fileName)
        {
            if (!fileName.EndsWith("hjson"))
                return string.Empty;

            var fileEntry = ThisTModFile.FirstOrDefault(f => f.Name == fileName);
            if (fileEntry is null)
                return "";
            Type type = typeof(ModLoader).Assembly.GetType("Terraria.ModLoader.Core.EntryReadStream")!;
            var ersCtor = type.GetConstructor([
                typeof(TmodFile),
                typeof(TmodFile.FileEntry),
                typeof(Stream),
                typeof(bool)
            ]);

            var BIN = BindingFlags.Instance | BindingFlags.NonPublic;
            var indep = (IList)typeof(TmodFile).GetField("independentEntryReadStreams", BIN)!.GetValue(ThisTModFile)!;
            var fileStream = (Stream)ersCtor!.Invoke([ThisTModFile, fileEntry, File.OpenRead(ThisTModFile.path), false]);
            //var fileStream = ThisTModFile.GetStream(fileEntry, true);
            indep.Add(fileStream);
            
            string fileContent = GetText(fileStream, fileEntry.IsCompressed) ?? "";
            fileStream.Close();
            return fileContent;

            #region old
            //var thisModName = typeof(LocalizeUtil).FullName!.Split(".")[0];
            //var thisMod = ModLoader.Mods.FirstOrDefault(f => f.Name == thisModName);
            //if (!(thisMod is null)) {
            //    //读取文件
            //    using Stream file = thisMod.GetFileStream(fileName);
            //    return GetText(file) ?? "";
            //}

            //return string.Empty;
            #endregion
        }

        public static string? GetText(Stream fileStream, bool isCompressed = false)
        {
            if (!fileStream.CanRead)
                return null;
            if (isCompressed)
                fileStream = new DeflateStream(fileStream, CompressionMode.Decompress);

            StreamReader fileRead = new StreamReader(fileStream, Encoding.UTF8);
            string? content = fileRead.ReadToEnd();
            return content;
        }

        /// <summary>
        /// 传入Hjson的内容,解析为键值，这个是TML的方法
        /// <para> LocalizationLoader.LoadTranslations</para>
        /// </summary>
        private static List<(string, string)> Method(string translationFileContents, string startChar = "", string fileName = "")
        {
            // Parse HJSON and convert to standard JSON
            var flattened = new List<(string, string)>();
            string jsonString;
            try {
                jsonString = HjsonValue.Parse(translationFileContents).ToString();
            } catch (Exception e) {
                string additionalContext = "";
                if (e is ArgumentException && Regex.Match(e.Message, "At line (\\d+),") is Match { Success: true } match && int.TryParse(match.Groups[1].Value, out int line)) {
                    string[] lines = translationFileContents.Replace("\r", "").Replace("\t", "    ").Split('\n');
                    int start = Math.Max(0, line - 4);
                    int end = Math.Min(lines.Length, line + 3);
                    var linesOutput = new StringBuilder();
                    for (int i = start; i < end; i++) {
                        if (line - 1 == i)
                            linesOutput.Append($"\n{i + 1}[c/ff0000:>" + lines[i] + "]");
                        else
                            linesOutput.Append($"\n{i + 1}:" + lines[i]);
                    }
                    additionalContext = "\nContext:" + linesOutput.ToString();
                }
                throw new Exception($"The localization file \"{fileName}\" is malformed and failed to load:{additionalContext} ", e);
            }

            // Parse JSON
            var jsonObject = JObject.Parse(jsonString);

            foreach (JToken t in jsonObject.SelectTokens("$..*")) {
                if (t.HasValues) {
                    continue;
                }

                // Due to comments, some objects can by empty
                if (t is JObject obj && obj.Count == 0)
                    continue;

                // Custom implementation of Path to allow "x.y" keys
                string path = "";
                JToken current = t;

                for (JToken parent = t.Parent; parent != null; parent = parent.Parent) {
                    path = parent switch
                    {
                        JProperty property => property.Name + (path == string.Empty ? string.Empty : "." + path),
                        JArray array => array.IndexOf(current) + (path == string.Empty ? string.Empty : "." + path),
                        _ => path
                    };
                    current = parent;
                }

                // removing instances of .$parentVal is an easy way to make this special key assign its value
                //  to the parent key instead (needed for some cases of .lang -> .hjson auto-conversion)

                ////修改的地方，因为没有完全按照TML的来
                ////path.Replace(".$parentVal", "")
                //if(path.StartsWith("Mods"))

                //    flattened.Add((path, t.ToString()));
                //else if(!path.StartsWith("Mods") && startChar == "")
                //    throw new Exception("给定文件不对，键没有以Mods.xxxx正确开头，如需要解决这个问题，可以传入 startChar");
                //else {
                //    if (startChar.EndsWith("."))
                //        path = startChar + path.Replace(".$parentVal", "");
                //    else
                //        path = startChar + "." + path.Replace(".$parentVal", "");
                //}
                #region ?
                //if (startChar != "")
                //    path = startChar + path.Replace(".$parentVal", "");
                //else
                //    path = path.Replace(".$parentVal", "");

                //var stringSplit = fileName.Split("/");
                //if (stringSplit.Length == 0) ;
                //else if (stringSplit.Length != 0)
                //    fileName = stringSplit[stringSplit.Length - 1];
                //if (path.StartsWith(fileName))
                //    path = path.Substring(fileName.Length);
                #endregion
                path = startChar + path.Replace(".$parentVal", "");
                flattened.Add((path, t.ToString()));
            }


            return flattened;
        }

    }

    public enum Language
    {
        简体中文,
        台湾繁体,
        //Potralia的害人汉化,
        //文言文汉化,
    }

}