using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Items.Artifacts
{
    public class IceArtifact : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Artifact");
            Tooltip.SetDefault("Use this item to swear allegiance to Yneas and you will get her blessing");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;

            Item.rare = ModContent.RarityType<AncestralModRarity>();
            Item.value = Item.sellPrice(gold: 1);
            Item.maxStack = 1;
            Item.consumable = true;
            Item.buffType = ModContent.BuffType<Buffs.ElementalPowerBuff.IceBlessingBuff>();
        }
        /*public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<StoneFragment>(), 5)
                .AddTile(ModContent.TileType<ElementalPedestalTile>())
                .Register();
        }*/
    }
}