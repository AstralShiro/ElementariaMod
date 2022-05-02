using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.AncestralBiome;
using ElementariaMod.Content.Tiles.AncestralBiome.AncestralAmbient.AncestralTree;

namespace ElementariaMod.Content.Tiles.AncestralBiome.AncestralBlocks
{
	public class AncestralGrassTile : ModTile
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
			SetModTree(new AncestralTreeTile());
			TileID.Sets.SpreadUnderground[Type] = true;
			//TileID.Sets.SpreadOverground[Type] = true;

			ItemDrop = ModContent.ItemType<AncestralDirt>();
			AddMapEntry(new Color(255, 120, 70));
		}
		public override int SaplingGrowthType(ref int style) 
		{
			style = 0;
			return ModContent.TileType<AncestralTreeSaplingTile>();
		}
	}
}