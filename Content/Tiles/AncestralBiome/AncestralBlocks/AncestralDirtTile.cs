using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.AncestralBiome;

namespace ElementariaMod.Content.Tiles.AncestralBiome.AncestralBlocks
{
	public class AncestralDirtTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			ItemDrop = ModContent.ItemType<AncestralDirt>();
			AddMapEntry(new Color(79, 79, 79));
		}
	}
}