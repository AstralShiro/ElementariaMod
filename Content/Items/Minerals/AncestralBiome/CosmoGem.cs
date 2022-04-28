using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ElementariaMod.Content.Items.Minerals.AncestralBiome
{
	public class CosmoGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Gem");
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
			Item.createTile = ModContent.TileType<Content.Tiles.Minerals.CosmoGemTile>();
			Item.width = 22;
			Item.height = 18;
			Item.value = 75000;
			Item.rare = ItemRarityID.Blue;
		}
	}
}
