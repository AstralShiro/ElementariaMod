using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T1
{
	public class IceCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice Core");
			Tooltip.SetDefault("A powerful and bright elemental core, allows you to create Ice element weapons");
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.Cyan;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<EmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<SaintGlobe>(), 25)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}