using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ElementariaMod.Content.Items.Materials.ElementalGlobes
{
	public class EarthGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Earth Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Earth Elemental Core");

			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5,11));

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 27;

			Item.maxStack = 999;
			Item.value = 100;

			Item.rare = ItemRarityID.Orange;
		}
	}
}