using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ElementariaMod.Content.Items.Minerals.AncestralBiome
{
	public class CosmoCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Crystal");
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 57;
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.autoReuse = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Content.Tiles.Minerals.CosmoCrystalTile>();
			Item.width = 12;
			Item.height = 12;
			Item.value = 75000;
			Item.rare = ItemRarityID.Blue;
		}
	}
}
