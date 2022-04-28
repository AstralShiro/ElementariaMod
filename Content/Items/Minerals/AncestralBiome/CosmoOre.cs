using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Tiles.Minerals;

namespace ElementariaMod.Content.Items.Minerals.AncestralBiome
{
	public class CosmoOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmo Ore");
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
			Item.createTile = ModContent.TileType<CosmoOreTile>();
			Item.width = 12;
			Item.height = 12;
			Item.value = 75000;
			Item.rare = ItemRarityID.Blue;
		}
	}
}
