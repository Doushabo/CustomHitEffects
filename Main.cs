namespace CustomHitEffects;

internal class Main : MelonMod
{
    // The method called when mod is loaded
    public override void OnInitializeMelon()
    {
        SettingManager.Register();
    }

    // The method called when mod is unloaded
    public override void OnDeinitializeMelon()
    {
    }
}