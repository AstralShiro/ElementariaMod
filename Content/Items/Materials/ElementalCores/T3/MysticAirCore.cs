using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T3
{
	public class MysticAirCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mystic Air Core");
			Tooltip.SetDefault("A powerful and bright mystic elemental core, allows you to create air element weapons");
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
				.AddIngredient(ModContent.ItemType<MysticEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<AirGlobe>(), 75)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}