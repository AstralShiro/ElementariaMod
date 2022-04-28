using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Items.Materials
{
	public class CosmoHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Butterveil, the ancestral Heart");
			Tooltip.SetDefault("Heart of the Cosmo, can be used to craft one Crafting Station TS");
		}

		public override void SetDefaults() {
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 1;
			Item.value = 100;
			Item.rare = ModContent.RarityType<ArcanumModRarity>();
		}
	}
}