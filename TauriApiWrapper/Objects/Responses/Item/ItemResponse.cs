using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapper.Objects.Responses
{
    public sealed class ItemResponse : BaseApiResponse
    {
        [JsonProperty("SocketContainedMask")]
        public long SocketContainedMask { get; set; }

        [JsonProperty("curDurability")]
        public long CurrentDurability { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("pernamentEnchDesc")]
        public string PernamentEnchDesc { get; set; }

        [JsonProperty("SocketBonusDesc")]
        public string SocketBonusDesc { get; set; }

        [JsonProperty("AllowedClassesStr")]
        public string AllowedClasses { get; set; }

        [JsonProperty("AllowedRacesStr")]
        public string AllowedRaces { get; set; }

        [JsonProperty("ReqSkillStr")]
        public string ReqSkill { get; set; }

        [JsonProperty("ReqSkillRank")]
        public long ReqSkillRank { get; set; }

        [JsonProperty("SocketContainedGem")]
        public object[] SocketContainedGem { get; set; }

        [JsonProperty("ID")]
        public long ID { get; set; }

        [JsonProperty("_Class")]
        public long Class { get; set; }

        [JsonProperty("_SubClass")]
        public long SubClass { get; set; }

        [JsonProperty("DisplayId")]
        public long DisplayID { get; set; }

        [JsonProperty("InventoryType")]
        public long InventoryType { get; set; }

        [JsonProperty("Quality_orig")]
        public long QualityOrig { get; set; }

        [JsonProperty("Quality")]
        public long Quality { get; set; }

        [JsonProperty("Flags")]
        public long Flags { get; set; }

        [JsonProperty("Flags2")]
        public long Flags2 { get; set; }

        [JsonProperty("Flags3")]
        public long Flags3 { get; set; }

        [JsonProperty("BuyCount")]
        public long BuyCount { get; set; }

        [JsonProperty("BuyPrice")]
        public long BuyPrice { get; set; }

        [JsonProperty("SellPrice")]
        public long SellPrice { get; set; }

        [JsonProperty("ItemLevel")]
        public long ItemLevel { get; set; }

        [JsonProperty("MaxCount")]
        public long MaxCount { get; set; }

        [JsonProperty("Stackable")]
        public long Stackable { get; set; }

        [JsonProperty("ContainerSlots")]
        public long ContainerSlots { get; set; }

        [JsonProperty("ScalingStatDistribution")]
        public long ScalingStatDistribution { get; set; }

        [JsonProperty("Delay")]
        public long Delay { get; set; }

        [JsonProperty("RangedModRange")]
        public long RangedModRange { get; set; }

        [JsonProperty("Bonding")]
        public long Bonding { get; set; }

        [JsonProperty("originalname")]
        public string Originalname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("RandomProperty")]
        public long RandomProperty { get; set; }

        [JsonProperty("RandomSuffix")]
        public long RandomSuffix { get; set; }

        [JsonProperty("ItemSet")]
        public long ItemSet { get; set; }

        [JsonProperty("SocketBonus")]
        public long SocketBonus { get; set; }

        [JsonProperty("GemProperties")]
        public long GemProperties { get; set; }

        [JsonProperty("m_inventoryIconOriginal")]
        public string InventoryIconOriginal { get; set; }

        [JsonProperty("m_inventoryIcon")]
        public string InventoryIcon { get; set; }

        [JsonProperty("m_className")]
        public string ClassName { get; set; }

        [JsonProperty("m_subClassName")]
        public string SubClassName { get; set; }

        [JsonProperty("BaseMinDamage")]
        public long BaseMinDamage { get; set; }

        [JsonProperty("BaseMaxDamage")]
        public long BaseMaxDamage { get; set; }

        [JsonProperty("BaseTypeDamage")]
        public long BaseTypeDamage { get; set; }

        [JsonProperty("ExtraMinDamage")]
        public long ExtraMinDamage { get; set; }

        [JsonProperty("ExtraMaxDamage")]
        public long ExtraMaxDamage { get; set; }

        [JsonProperty("ExtraTypeDamage")]
        public long ExtraTypeDamage { get; set; }

        [JsonProperty("MaxDurability")]
        public long MaxDurability { get; set; }

        [JsonProperty("RequiredLevel")]
        public long RequiredLevel { get; set; }

        [JsonProperty("RequiredSkill")]
        public long RequiredSkill { get; set; }

        [JsonProperty("RequiredSkillRank")]
        public long RequiredSkillRank { get; set; }

        [JsonProperty("RequiredSpell")]
        public long RequiredSpell { get; set; }

        [JsonProperty("RequiredHonorRank")]
        public long RequiredHonorRank { get; set; }

        [JsonProperty("RequiredCityRank")]
        public long RequiredCityRank { get; set; }

        [JsonProperty("RequiredReputationFaction")]
        public long RequiredReputationFaction { get; set; }

        [JsonProperty("RequiredReputationRank")]
        public long RequiredReputationRank { get; set; }

        [JsonProperty("Armory")]
        public long Armory { get; set; }

        [JsonProperty("SpellTrigger")]
        public long[] SpellTrigger { get; set; }

        [JsonProperty("SpellId")]
        public object[] SpellId { get; set; }

        [JsonProperty("ItemStat")]
        public ItemStat[] ItemStat { get; set; }

        [JsonProperty("Socket")]
        public Socket[] Socket { get; set; }

        [JsonProperty("itemsetInfo")]
        public string ItemSetInfoHtml { get; set; }

        [JsonProperty("ItemSetInfo")]
        public ItemSetInfo ItemSetInfo { get; set; }

        [JsonProperty("item_equip")]
        public string ItemEquip { get; set; }

        [JsonProperty("armor_type")]
        public string ArmorType { get; set; }

        [JsonProperty("weapon_damage")]
        public bool WeaponDamage { get; set; }

        [JsonProperty("minDmg")]
        public long MinDmg { get; set; }

        [JsonProperty("maxDmg")]
        public long MaxDmg { get; set; }

        [JsonProperty("dmg_speed")]
        public long DmgSpeed { get; set; }

        [JsonProperty("ench")]
        public string Ench { get; set; }

        [JsonProperty("item_armor")]
        public string ItemArmor { get; set; }

        [JsonProperty("quality_color_original")]
        public string QualityColorOriginal { get; set; }

        [JsonProperty("quality_color")]
        public string QualityColor { get; set; }

        [JsonProperty("item_name_original")]
        public string ItemNameOriginal { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("description")]
        public string TemperaturesDescription { get; set; }

        [JsonProperty("is_heroic")]
        public long IsHeroic { get; set; }

        [JsonProperty("bonding")]
        public string TemperaturesBonding { get; set; }

        [JsonProperty("haveCreator")]
        public bool HaveCreator { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("races")]
        public string Races { get; set; }

        [JsonProperty("classes")]
        public string Classes { get; set; }

        [JsonProperty("need_level")]
        public long NeedLevel { get; set; }

        [JsonProperty("need_skill")]
        public string NeedSkill { get; set; }

        [JsonProperty("need_skill_rank")]
        public long NeedSkillRank { get; set; }

        [JsonProperty("need_reputation_rank")]
        public string NeedReputationRank { get; set; }

        [JsonProperty("need_reputation_faction")]
        public string NeedReputationFaction { get; set; }

        [JsonProperty("durability")]
        public Durability Durability { get; set; }

        [JsonProperty("startquesto")]
        public long StartQuesto { get; set; }

        [JsonProperty("fullLootInfo")]
        public string FullLootInfo { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("itemLevel")]
        public long TemperaturesItemLevel { get; set; }

        [JsonProperty("transmogid")]
        public long TransmogID { get; set; }

        [JsonProperty("transmogitemname")]
        public string TransmogItemName { get; set; }

        [JsonProperty("transmogitemicon")]
        public string TransmogItemIcon { get; set; }

        [JsonProperty("upgradeid")]
        public long UpgradeID { get; set; }

        [JsonProperty("upgradelevel")]
        public long Upgradelevel { get; set; }

        [JsonProperty("upgrademaxlevel")]
        public long UpgradeMaxLevel { get; set; }

        [JsonProperty("upgradetext")]
        public string UpgradeText { get; set; }

        [JsonProperty("itemnamedescription")]
        public string ItemNameDescription { get; set; }

        [JsonProperty("useenchantment")]
        public string UseEnchantment { get; set; }
    }
}