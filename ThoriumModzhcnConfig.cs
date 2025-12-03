using Newtonsoft.Json;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Terraria.Localization;
using Terraria.ModLoader.Config;

namespace ThoriumModzhcn.Systems;

public class ThoriumModConfig : ModConfig
{
    public override LocalizedText DisplayName
    => Terraria.Localization.Language.GetOrRegister("ThoriumModzhcnConfig", () => "瑟银汉化补丁设置");
    public Language 语言转换;

    [JsonIgnore]
    public CancellationTokenSource CTS;

    [DefaultValue(true)]
    public bool 世界启用提示;

    public override ConfigScope Mode => ConfigScope.ClientSide;

    public override void OnChanged()
    {
        if (CTS == null) {
            CTS = new CancellationTokenSource();
        } else {
            CTS.Cancel();
            CTS = new CancellationTokenSource();
        }

        LocalizeNew.CurrentLanguage = 语言转换;
        if (LocalizeNew.IsPostSetupContent) {
            _ = Task.Run(() => {
                LanguageManager.Instance.RecalculateBoundTextValues();
            }/*, CTS.Token*/);
        }

        base.OnChanged();
    }
}