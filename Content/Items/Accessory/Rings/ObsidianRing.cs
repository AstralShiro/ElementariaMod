using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Items.Accessory.Rings
{
    public class ObsidianRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Obsidian ring");
            Tooltip.SetDefault("Lava immune");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = 2;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaImmune = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.MysticEmptyCore>(), 1)
                .AddIngredient(ItemID.Obsidian, 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT3Tile>())
                .Register();
        }
    }
}