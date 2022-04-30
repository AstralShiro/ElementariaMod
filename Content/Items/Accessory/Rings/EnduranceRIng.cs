using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class EnduranceRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endurance Ring");
            Tooltip.SetDefault("Increase your defense but decrease your movement speed. +15 denfese, -20% movement speed.");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare =  ItemRarityID.LightRed;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 15;
            player.moveSpeed -= 0.20f;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.DreamEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.SupremeStoneRing>(), 1)
                .AddIngredient(ItemID.StoneBlock, 50)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT4Tile>())
                .Register();
        }
    }
}