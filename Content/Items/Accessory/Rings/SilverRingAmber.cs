using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class SilverRingAmber : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold ring with amber");
            Tooltip.SetDefault("Increase all damage : +25% Damage");
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
            player.GetDamage(DamageClass.Melee) += 0.25f;
            player.GetDamage(DamageClass.Magic) += 0.25f;
            player.GetDamage(DamageClass.Ranged) += 0.25f;
            player.GetDamage(DamageClass.Summon) += 0.25f;
            player.GetDamage(DamageClass.Throwing) += 0.25f;

        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.RareEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.SilverRingTopaz>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.GoldRingAmethyst>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.SilverRingEmerald>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.SilverRingSapphire>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.GoldRingRuby>(), 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyT2Tile>())
                .Register();
        }
    }
}