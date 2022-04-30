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
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			//drop = ItemType<Items.Placeable.ArcanumBiome.ArcanumStone>();
			AddMapEntry(new Color(79, 79, 79));

			ItemDrop = ModContent.ItemType<ArcanumStone>();
		}
	}
}