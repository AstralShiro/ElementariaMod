using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Materials
{
	public class PlanteraHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Plantera Heart");
			Tooltip.SetDefault("Heart of the Queen of nature, can be used to craft one Crafting Station T3");
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