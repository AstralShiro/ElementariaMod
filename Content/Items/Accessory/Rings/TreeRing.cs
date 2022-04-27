using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class TreeRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tree ring");
            Tooltip.SetDefault("Increase you life and give life regen. +150HP, Life regen (3HP per second)");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = 4;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen = 3;
            player.statLifeMax2 += 150;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.DreamEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.SupremeVitalRing>(), 1)
                .AddIngredient(ItemID.Wood, 50)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT4Tile>())
                .Register();
        }
    }
}