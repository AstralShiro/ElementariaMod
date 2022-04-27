using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class StarRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Ring");
            Tooltip.SetDefault("Increases mana give mana regen and take mana stars when are far : +150 Mana, Mana regen (3 mana per second), Mana Magnet");
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
            player.statManaMax2 += 150;
            player.manaRegen += 3;
            player.manaMagnet = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.DreamEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.ArchmageRing>(), 1)
                .AddIngredient(ItemID.ManaCrystal, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT4Tile>())
                .Register();
        }
    }
}