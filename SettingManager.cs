namespace CustomHitEffects;

internal static class SettingManager
{
    private static readonly string ConfigPath = Path.Combine(MelonEnvironment.UserDataDirectory, $"{Name}.cfg");
    private static readonly string EffectPath = Path.Combine(MelonEnvironment.UserDataDirectory, $"BattleEffect");
    
    private static MelonPreferences_Entry<Data> _setting;

    public static Data Setting => _setting.Value;

    internal static void Register()
    {
        var category = MelonPreferences.CreateCategory(Name, Name);
        category.SetFilePath(ConfigPath);
        
        _setting = category.CreateEntry("TestData", new Data("identifierEffect"), "Example Data");
    }
}