using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T1
{
	public class DarkCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dark Core");
			Tooltip.SetDefault("A powerful and bright elemental core, allows you to create dark element weapons");
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.LightPurple;
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<EmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<DarkGlobe>(), 25)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}