using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.AncestralBiome;

namespace ElementariaMod.Content.Walls.AncestralBiome
{
	public class AncestralDirtWall : ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallHouse[Type] = true;
			ItemDrop = ModContent.ItemType<AncestralDirtItemWall>();
			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}