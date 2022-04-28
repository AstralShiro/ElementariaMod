using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class CrystalRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Ring");
            Tooltip.SetDefault("Made you invincible when you are hitted for a little time and made u immune to the lava.");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.longInvince = true;
            player.lavaImmune = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.DreamEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.ObsidianRing>(), 1)
                .AddIngredient(ItemID.CrystalShard, 50)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT4Tile>())
                .Register();
        }
    }
}