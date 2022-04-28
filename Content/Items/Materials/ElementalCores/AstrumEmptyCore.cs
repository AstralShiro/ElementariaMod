using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Materials.ElementalCores
{
	public class AstrumEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Astrum Empty Core");
			Tooltip.SetDefault("A mystical stone, it can be used to Astrum elemental cores");
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
				.AddIngredient(ModContent.ItemType<Content.Items.Materials.ArcanumHeart>(), 1)
				.AddIngredient(ModContent.ItemType<Content.Items.Materials.ElementalCores.EmptyCore>(), 1)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}