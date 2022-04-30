using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.AncestralBiome;
using ElementariaMod.Content.Tiles.AncestralBiome.AncestralAmbient.AncestralTree;

namespace ElementariaMod.Content.Tiles.AncestralBiome.AncestralBlocks
{
	public class AncestralWoodTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			ItemDrop = ModContent.ItemType<AncestralWood>();
			AddMapEntry(new Color(80, 175, 210));
			SetModTree(new AncestralTreeTile());
		}
	}
}