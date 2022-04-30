using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.ArcanumBiome;
using ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumAmbient.ArcanumTree;

namespace ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks
{
	public class ArcanumWoodTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			ItemDrop = ModContent.ItemType<ArcanumWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new ArcanumTreeTile());
		}
	}
}