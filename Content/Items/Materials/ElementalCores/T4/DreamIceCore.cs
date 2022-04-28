using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Materials;
using ElementariaMod.Content.Tiles.CraftingStation;
using ElementariaMod.Content.Items.Materials.ElementalGlobes;

namespace ElementariaMod.Content.Items.Materials.ElementalCores.T4
{
	public class DreamIceCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dream Ice Core");
			Tooltip.SetDefault("A powerful and bright dream elemental core, allows you to create ice element weapons");
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
				.AddIngredient(ModContent.ItemType<DreamEmptyCore>(), 1)
				.AddIngredient(ModContent.ItemType<IceGlobe>(), 100)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}