using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Accessory.Rings
{
    public class UltimatumRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimatum Ring");
            Tooltip.SetDefault("Give all the effects of the rings\nMana magnet\n+50 damage\nLife regen (4 HP per second)\nMana regen (4 Mana per second)\n+20 defense\n+20 movement speed\n+200 HP\n+200 Mana\nStar Cloak\nLava immune\nInvincibilty when you are hitted for a little time");
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.value = 10;
            Item.rare = 5;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //Damage
            player.GetDamage(DamageClass.Melee) += 0.5f;
            player.GetDamage(DamageClass.Ranged) += 0.5f;
            player.GetDamage(DamageClass.Magic) += 0.5f;
            player.GetDamage(DamageClass.Throwing) += 0.5f;
            player.GetDamage(DamageClass.Summon) += 0.5f;
            
            //Buffs
            player.lifeRegen = 4;
            player.statLifeMax2 += 200;
            player.statManaMax2 += 200;
            player.manaRegen += 4;
            player.statDefense += 20;
            player.moveSpeed -= 0.15f;
            player. = true;
            player.lavaImmune = true;
            player.manaMagnet = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.CosmoEmptyCore>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.GlassRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.TreeRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.StarRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.EnduranceRing>(), 1)
                .AddIngredient(ModContent.ItemType<Content.Items.Accessory.Rings.CrystalRing>(), 1)
                .AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ArcaneSmithyTSTile>())
                .Register();
        }
    }
}