using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class SilverRingSapphire : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver ring with sapphire");
            Tooltip.SetDefault("Increases magic damage : +20%");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.value = 10;
            Item.rare = 1;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.2f;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Sapphire, 1)
                .AddIngredient(ItemID.TungstenBar, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyTile>())
                .Register();

            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Sapphire, 1)
                .AddIngredient(ItemID.SilverBar, 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStatio.ArcaneSmithyTile>())
                .Register();
        }
    }
}