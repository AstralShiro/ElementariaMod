using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Materials;
using ElementariaMod.Content.Items.Materials.ElementalCores;
using ElementariaMod.Content.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Materials.ElementalCores
{
	public class MysticEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mystic Empty Core");
			Tooltip.SetDefault("A rare mystical stone, it can be used to create Supreme elemental cores");
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
				.AddIngredient(ModContent.ItemType<PlanteraHeart>(), 1)
				.AddIngredient(ModContent.ItemType<EmptyCore>(), 1)
				.AddTile(ModContent.TileType<ElementalPedestalTile>())
				.Register();
		}
	}
}