using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.TSS
{
	public class AstrumEarthCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astrum Earth Core");
			Tooltip.SetDefault("A powerful and bright dream elemental core, allows you to create Earth element weapons");
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
				.AddIngredient(ModContent.ItemType<AstrumEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<EarthGlobe>(), 200)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}