using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Placeable.Decoration;

namespace ElementariaMod.Content.Tiles.Decorations
{
	public class AncestralBricksTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;

            ItemDrop = ModContent.ItemType<AncestralBricks>();

            AddMapEntry(new Color(200, 200, 200));

			// todo: implement
			// SetModTree(new Trees.ExampleTree());
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		// todo: implement
		// public override void ChangeWaterfallStyle(ref int style) {
		// 	style = mod.GetWaterfallStyleSlot("ExampleWaterfallStyle");
		// }
		//
		// public override int SaplingGrowthType(ref int style) {
		// 	style = 0;
		// 	return TileType<ExampleSapling>();
		// }
	}
}