using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class GoldRingDiamond: ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with diamond");
            Tooltip.SetDefault("Increase all damage : +30% Damage");
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
            player.GetDamage(DamageClass.Melee) += 0.3f;
            player.GetDamage(DamageClass.Magic) += 0.3f;
            player.GetDamage(DamageClass.Ranged) += 0.3f;
            player.GetDamage(DamageClass.Throwing) += 0.3f;
            player.GetDamage(DamageClass.Summon) += 0.3f;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Diamond, 1)
                .AddIngredient(ItemID.GoldBar, 5)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyTile>())
                .Register();

            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
                .AddIngredient(ItemID.Diamond, 1)
                .AddIngredient(ItemID.PlatinumBar, 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStatio.ArcaneSmithyTile>())
                .Register();
        }
    }
}