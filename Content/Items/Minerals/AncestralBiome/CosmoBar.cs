using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ElementariaMod.Content.Items.Minerals.AncestralBiome
{
	public class CosmoBar : ModItem
	{ 
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Bar");
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 99;
			Item.value = 750;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = TileType<Tiles.Minerals.CosmoBarTile>();
			Item.placeStyle = 0;
			Item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<Content.Items.Minerals.AncestralBiome.CosmoOre>(), 4)
				.AddTile(TileID.Furnaces)
				.Register();
		}
	}
}