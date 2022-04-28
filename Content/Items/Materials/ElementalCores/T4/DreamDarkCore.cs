using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T4
{
	public class DreamDarkCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dream Dark Core");
			Tooltip.SetDefault("A powerful and bright dream elemental core, allows you to create Dark element weapons");
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<DreamEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<DarkGlobe>(), 100)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}