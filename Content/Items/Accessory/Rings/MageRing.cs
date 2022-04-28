using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class MageRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mage Ring");
            Tooltip.SetDefault("Increases mana. +50 Mana");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 50;
        }

        public override void AddRecipes()
        {
            CreateRecipe(999)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.RareEmptyCore>(), 1)
                .AddIngredient(ItemID.ManaCrystal, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT3Tile>())
                .Register();
        }
    }
}