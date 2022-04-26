using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Materials
{
	public class WoFHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wall of Flesh Heart");
			Tooltip.SetDefault("Heart of the King of Hell, can be used to craft one Crafting Station T2");
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