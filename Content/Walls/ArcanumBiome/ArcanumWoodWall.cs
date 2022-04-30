using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.ArcanumBiome;

namespace ElementariaMod.Content.Walls.ArcanumBiome
{
	public class ArcanumWoodWall : ModWall
	{
		public override void SetStaticDefaults() 
		{
			Main.wallHouse[Type] = false;
			ItemDrop = ModContent.ItemType<ArcanumWoodItemWall>();
			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		//public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
		//	r = 0.4f;
		//	g = 0.4f;
		//	b = 0.4f;
		//}
	}
}