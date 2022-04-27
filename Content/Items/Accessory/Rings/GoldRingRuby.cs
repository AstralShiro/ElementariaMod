using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class GoldRingRuby : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with ruby");
            Tooltip.SetDefault("Increases melee damage : +20%");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = -12;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Melee) += 0.2f;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Ruby, 1)
                .AddIngredient(ItemID.GoldBar, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyTile>())
                .Register();

            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Ruby, 1)
                .AddIngredient(ItemID.PlatinumBar, 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStatio.ArcaneSmithyTile>())
                .Register();
        }
    }
}