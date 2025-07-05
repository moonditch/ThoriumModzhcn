using Hjson;
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
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ThoriumModzhcn.Systems;

public class TFile(string filePath)
{
    private static TmodFile? thisTModFile;
    private static TmodFile ThisTModFile
    {
        get
        {
            if (thisTModFile is null) {
                LoadModAssembly.LoadModContext.TryGetValue(
                    typeof(TFile).FullName!.Split('.')[0],
                    out var modContext
                );
                thisTModFile = (TmodFile)modContext!.GetType().GetField("modFile")!.GetValue(modContext)!;
            }
            return thisTModFile!;
        }
    }
    public string FilePath { get; } = filePath;
    public string GetText()
    {
        if (!FilePath.EndsWith("hjson"))
            return string.Empty;

        var fileEntry = ThisTModFile.FirstOrDefault(f => f.Name == FilePath);
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

        using var fileStream =
            (Stream)ersCtor!
            .Invoke([
                ThisTModFile,
                fileEntry,
                File.OpenRead(ThisTModFile.path),
                false
            ]);

        //var fileStream = ThisTModFile.GetStream(fileEntry, true);
        indep.Add(fileStream);

        string fileContent = GetText(fileStream, fileEntry.IsCompressed) ?? "";
        fileStream.Dispose();
        return fileContent;
    }


    public static List<TFile> Where(Func<string, bool> func) => GetFiles(func);
    public static List<TFile> GetFiles(Func<string, bool> func)
    {
        var filePaths = ThisTModFile.GetFileNames().Where(func);
        var tlist = new List<TFile>();
        foreach (var fp in filePaths) {
            tlist.Add(new TFile(fp));
        }
        return tlist;
    }
    private static string? GetText(Stream fileStream, bool isCompressed = false)
    {
        if (!fileStream.CanRead)
            return null;
        if (isCompressed)
            fileStream = new DeflateStream(fileStream, CompressionMode.Decompress);

        using StreamReader fileRead = new StreamReader(fileStream, Encoding.UTF8);
        string? content = fileRead.ReadToEnd();
        return content;
    }

    /// <summary>
    /// fileName必须以 en-us_fileName的格式，并且路径内不能出现其他'_'
    /// </summary>
    /// <returns>返回文件Key值应该的开头</returns>
    private string GetStartChars()
    {
        var splitString = FilePath.Split("_");
        if (splitString.Length == 1) return "";
        //if (splitString[0] == "IL") return "";
        if (FilePath.Contains("IL_")) return "";
        return splitString[1].Replace(".hjson", ".");
    }

    public List<(string key, string value)> ParseToKeyValue()
    {
        if (FilePath.Contains("IL_")) {
            List<(string key, string value)> kv = [];
            foreach (KeyValuePair<string, Hjson.JsonValue> keyValue in HjsonValue.Parse(GetText())) {
                kv.Add(keyValue.Key, keyValue.Value);
            }
            return kv;
        } else {
            return ParseHjsonToKeyValue();
        }
    }

    private List<(string key, string value)> ParseHjsonToKeyValue(string fileName = "")
    {
        string translationFileContents = GetText();
        string startChar = GetStartChars();
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
            path = startChar + path.Replace(".$parentVal", "");
            flattened.Add((path, t.ToString()));
        }


        return flattened;
    }
}
