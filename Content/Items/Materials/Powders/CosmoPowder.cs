using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Items.Powders;

namespace Elementaria.Items.Powders
{

    public class AncestralPowder : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancestral powder");
            Tooltip.SetDefault("Use it for craft the Ancestral Solution");
        }
        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 14;
            item.rare = 1;
            item.value = Item.sellPrice(copper: 50);
            item.maxStack = 999;
        }
        public override void AddRecipes() {
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ModContent.ItemType<IcePowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<DarkPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<AirPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<EarthPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<HallowPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<WaterPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<ThunderPowder>(), 5);
        recipe.AddIngredient(ModContent.ItemType<WaterPowder>(), 5);
		recipe.SetResult(this, 5);
		recipe.AddRecipe();
		}
    }
}