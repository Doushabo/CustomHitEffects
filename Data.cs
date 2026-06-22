using Tomlet.Attributes;

namespace CustomHitEffects;

// Data class for the Mod
public class Data
{
    [TomlPrecedingComment("Effects Pack")]
    internal readonly string CurrentEffect;

    // Constructor for MelonLoader to Deserialize the Data
    public Data()
    {
    }

    internal Data(string currentEffect)
    {
        CurrentEffect = currentEffect;
    }
}