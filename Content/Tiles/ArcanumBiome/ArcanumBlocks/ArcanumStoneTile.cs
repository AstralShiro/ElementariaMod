using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.ArcanumBiome;

namespace ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks
{
	public class ArcanumStoneTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			//drop = ItemType<Items.Placeable.ArcanumBiome.ArcanumStone>();
			AddMapEntry(new Color(20, 20, 20));

			ItemDrop = ModContent.ItemType<ArcanumStone>();
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			Tile tile = Main.tile[i, j];
			if (tile.TileFrameX < 66)
			{
				r = 0.55f;
				g = 0.3f;
				b = 1f;
			}
		}
	}
}