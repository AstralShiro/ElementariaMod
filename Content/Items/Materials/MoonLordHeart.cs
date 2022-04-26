using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Materials
{
	public class MoonLordHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Moon Lord Heart");
			Tooltip.SetDefault("Heart of the King fo the dreams, can be used to craft one Crafting Station T4");
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 1;
			Item.value = 100;
			Item.rare = ItemRarityID.Expert;
		}
	}
}