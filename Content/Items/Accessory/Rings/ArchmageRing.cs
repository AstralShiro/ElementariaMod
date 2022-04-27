using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class ArchmageRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Archmage Ring");
            Tooltip.SetDefault("Increases mana : +100 Mana, Mana regen (2 mana per second)");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = 3;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 100;
            player.manaRegen += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.MysticEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.MageRing>(), 1)
                .AddIngredient(ItemID.ManaCrystal, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT3Tile>())
                .Register();
        }
    }
}