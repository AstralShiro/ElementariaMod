using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Terraria.ID;

using ElementariaMod.Content.Walls.AncestralBiome;

namespace ElementariaMod.Content.Items.Placeable.AncestralBiome
{
	public class AncestralWoodItemWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancestral Wood");
		}
		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<AncestralWoodWall>();
		}
	}
}