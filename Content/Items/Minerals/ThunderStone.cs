using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Collections.Generic;

namespace ElementariaMod.Content.Items.Minerals
{
	public class ThunderStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Thunder Stone");
			Tooltip.SetDefault("A stone infused with the strength of heaven");

			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5,6));
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 50;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			TooltipLine Line = new(Mod, "Thunder Stone", "Thunder Element");
			Line.OverrideColor = new Color(255, 255, 0);
			tooltips.Add(Line);
		}

		public override void SetDefaults() {
			Item.width = 27;
			Item.height = 30;
			Item.maxStack = 999;
			Item.value = Item.sellPrice(silver: 2, copper: 75);
			Item.rare = ItemRarityID.Yellow;
		}
			public override void PostUpdate() {
			Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
		}
	}
}