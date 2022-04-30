using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;

using ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks;

namespace ElementariaMod.Content.Items.Placeable.ArcanumBiome
{
	public class ArcanumDirt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcanum Grass");
		}
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createTile = TileType<ArcanumDirtTile>();
		}
	}
}