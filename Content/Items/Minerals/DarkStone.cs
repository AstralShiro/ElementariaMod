using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ElementariaMod.Content.Items.Minerals
{
	public class DarkStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dark Stone");
			Tooltip.SetDefault("A stone infused with darkness");

			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5,6));
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 50;
		}

		public override void SetDefaults() {
			Item.width = 27;
			Item.height = 30;
			Item.maxStack = 999;
			Item.value = Item.sellPrice(silver: 2, copper: 75);
			Item.rare = ItemRarityID.Purple;
		}
			public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
		}
	}
}