namespace CustomHitEffects;

internal static class SettingManager
{
    private static readonly string ConfigPath = Path.Combine(MelonEnvironment.UserDataDirectory, $"{Name}.cfg");
    
    
    private static MelonPreferences_Entry<Data> _setting;

    public static Data Setting => _setting.Value;

    internal static void Register()
    {
        var category = MelonPreferences.CreateCategory(Name, Name);
        category.SetFilePath(ConfigPath);
        
        _setting = category.CreateEntry("Setting", new Data("defaultEffect"));
    }
}