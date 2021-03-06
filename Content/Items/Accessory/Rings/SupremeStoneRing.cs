using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class SupremeStoneRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supreme Stone ring");
            Tooltip.SetDefault("Increase your defense. +10 Defense");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 10;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.MysticEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.StoneRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.StoneRing>(), 1)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT3Tile>())
                .Register();
        }
    }
}