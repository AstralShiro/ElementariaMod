using Terraria.ID;
using Terraria.ModLoader;
using Elementaria.Items.Materials;

using Elementaria.Tiles.CraftingStation;
using Elementaria.Items.Materials.Globe;

namespace Elementaria.Items.Materials.ElementalCores.T1
{
	public class FireCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fire Core");
			Tooltip.SetDefault("A powerful and bright elemental core, allows you to create Fire element weapons");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Red;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EmptyCore>(), 1);
			recipe.AddIngredient(ModContent.ItemType<FireGlobe>(), 25);
			recipe.AddTile(ModContent.TileType<ElementalPedestalTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}