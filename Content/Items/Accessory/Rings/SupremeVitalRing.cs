using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class SupremeVitalRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supreme Vital Ring");
            Tooltip.SetDefault("Increase you life and give life regen. +100HP, Life regen (2HP per second)");
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
            player.lifeRegen = 2;
            player.statLifeMax2 += 100;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.MysticEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.VitalRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.VitalRing>(), 1)
                .AddIngredient(ItemID.LifeCrystal, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT3Tile>())
                .Register();
        }
    }
}