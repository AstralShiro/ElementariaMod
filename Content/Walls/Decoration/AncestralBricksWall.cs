using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Placeable.Decoration;

namespace ElementariaMod.Content.Walls.Decoration
{
	public class AncestralBricksWall : ModWall
	{
		public override void SetStaticDefaults() {
			Main.wallHouse[Type] = true;

			ItemDrop = ModContent.ItemType<AncestralBricksItemWall>();

			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
}