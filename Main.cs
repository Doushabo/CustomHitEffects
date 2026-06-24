namespace CustomHitEffects;

internal class Main : MelonMod
{
    private static readonly string EffectPath = Path.Combine(MelonEnvironment.UserDataDirectory, "BattleEffect");
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
        SettingManager.Register();

        if (!Directory.Exists(EffectPath))
        {
            Directory.CreateDirectory(EffectPath);
        }

    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
    }
}