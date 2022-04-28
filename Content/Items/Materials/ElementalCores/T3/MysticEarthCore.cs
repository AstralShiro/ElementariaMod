using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T3
{
	public class MysticEarthCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mystic Earth Core");
			Tooltip.SetDefault("A powerful and bright mystic elemental core, allows you to create Earth element weapons");
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
				.AddIngredient(ModContent.ItemType<MysticEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<EarthGlobe>(), 75)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}