using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.ArcanumBiome;

namespace ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks
{
	public class ArcanumDirtTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			ItemDrop = ModContent.ItemType<ArcanumDirt>();
			AddMapEntry(new Color(79, 79, 79));
		}
	}
}