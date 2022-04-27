using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Materials;
using ElementariaMod.Content.Items.Materials.ElementalCores;
//using Elementaria.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Materials.ElementalCores
{
	public class RareEmptyCore : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rare Empty Core");
			Tooltip.SetDefault("A rare mystical stone, it can be used to create T1 elemental cores");
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
				.AddIngredient(ModContent.ItemType<WoFHeart>(), 1)
				.AddIngredient(ModContent.ItemType<EmptyCore>(),1)
				//.AddTile(ModContent.TileType<Content.Tiles.CraftingStation.ElementalPedestal>());
				.Register();
		}
	}
}