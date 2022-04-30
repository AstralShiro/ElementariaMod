using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.ArcanumBiome;
using ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumAmbient.ArcanumTree;

namespace ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks
{
	public class ArcanumGrassTile : ModTile
	{

        public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			TileID.Sets.Grass[Type] = true;
			TileID.Sets.NeedsGrassFraming[Type] =true;
			TileID.Sets.NeedsGrassFramingDirt[Type] = TileID.Dirt;
			SetModTree(new ArcanumTreeTile());
			TileID.Sets.SpreadUnderground[Type] = true;
			//TileID.Sets.SpreadOverground[Type] = true;

			ItemDrop = ModContent.ItemType<ArcanumDirt>();
			AddMapEntry(new Color(255, 120, 70));
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			Tile tile = Main.tile[i, j];
			if (tile.TileFrameX < 66)
			{
				r = 0.9f;
				g = 0.9f;
				b = 0.9f;
			}
		}
		public override int SaplingGrowthType(ref int style) 
		{
			style = 0;
			return ModContent.TileType<ArcanumTreeSaplingTile>();
		}
	}
}