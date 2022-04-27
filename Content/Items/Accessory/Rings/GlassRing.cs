using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class GlassRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glass Ring");
            Tooltip.SetDefault("Increase all damage : +40% Damage");
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
            player.GetDamage(DamageClass.Melee) += 0.4f;
            player.GetDamage(DamageClass.Ranged) += 0.4f;
            player.GetDamage(DamageClass.Magic) += 0.4f;
            player.GetDamage(DamageClass.Throwing) += 0.4f;
            player.GetDamage(DamageClass.Summon) += 0.4f;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.DreamEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.GoldRingDiamond>(), 1)
                .AddIngredient(ItemID.Glass, 50)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT4Tile>())
                .Register();
        }
    }
}