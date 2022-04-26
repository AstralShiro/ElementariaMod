using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ElementariaMod.Content.Items.Materials
{
	public class ArcanumHeart : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Butterveil, The arcanum Heart");
			Tooltip.SetDefault("Heart of the Dark cosmo, can be used to craft one Crafting Station TSS");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}
		public override void SetDefaults() 
		{
			Item.width = 32;
			Item.height = 32;

			Item.maxStack = 1;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
			//Item.rare = ItemRarityID.Green;
		}
	}
}