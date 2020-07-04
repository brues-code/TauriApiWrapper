using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    public enum Realm
    {
        Undefined,

        [Name("[EN] Evermoon"), LinkedRealm(Tauri), Expansion(Expansion.MistsOfPandaria)]
        Evermoon,

        [Name("[HU] Tauri WoW Server"), Expansion(Expansion.MistsOfPandaria)]
        Tauri,

        [Name("[HU] Warriors of Darkness"), Expansion(Expansion.MistsOfPandaria)]
        WoD,

        [Name("Crystalsong"), Expansion(Expansion.WrathOfTheLichKing)]
        Crystalsong,
    }
}