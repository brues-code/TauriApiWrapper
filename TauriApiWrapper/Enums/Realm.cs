using TauriApiWrapper.Attributes;

namespace TauriApiWrapper.Enums
{
    public enum Realm
    {
        Undefined,

        [Name("[EN] Evermoon"), LinkedRealm(Tauri)]
        Evermoon,

        [Name("[HU] Tauri WoW Server")]
        Tauri,

        [Name("[HU] Warriors of Darkness")]
        WoD,

        [Name("Crystalsong")]
        Crystalsong,
    }
}