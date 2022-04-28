using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Materials.ElementalCores
{
	public class CosmoEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cosmo Empty Core");
			Tooltip.SetDefault("A mystical stone, it can be used to Cosmo elemental cores");
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<Content.Items.Materials.CosmoHeart>(), 1)
				.AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}