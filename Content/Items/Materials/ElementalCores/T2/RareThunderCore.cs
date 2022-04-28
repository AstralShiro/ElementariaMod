using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T2
{
	public class RareThunderCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rare Thunder Core");
			Tooltip.SetDefault("A powerful and bright rare elemental core, allows you to create Thunder element weapons");
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.Green;
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<RareEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<ThunderGlobe>(), 50)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}