using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Elementaria.Tiles.CraftingStation;
using Elementaria.Items.Materials.Minerals;
using Elementaria.Items.Materials.Globe;

namespace Elementaria.Items.Powders
{

    public class HallowPowder : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallow powder");
            Tooltip.SetDefault("Use it for craft the Hallow Powder");
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
		recipe.AddIngredient(ModContent.ItemType<HallowStone>(), 5);
        recipe.AddTile(ModContent.TileType<MortarTile>());
		recipe.SetResult(this, 5);
		recipe.AddRecipe();
        
        new ModRecipe(mod);
		recipe.AddIngredient(ModContent.ItemType<HallowGlobe>(), 15);
        recipe.AddTile(ModContent.TileType<MortarTile>());
		recipe.SetResult(this, 5);
		recipe.AddRecipe();
		}
    }
}