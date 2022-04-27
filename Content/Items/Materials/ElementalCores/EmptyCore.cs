using Terraria.ID;
using Terraria.ModLoader;
using ElementariaMod.Content.Items.Minerals;

//using Elementaria.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Materials.ElementalCores
{
	public class EmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Empty Core");
			Tooltip.SetDefault("A mystical stone, it can be used to create elemental cores");
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
				.AddIngredient(ModContent.ItemType<StoneFragment>(), 5)
				//.AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ElementalPedestal>());
				.Register();
		}
	}
}