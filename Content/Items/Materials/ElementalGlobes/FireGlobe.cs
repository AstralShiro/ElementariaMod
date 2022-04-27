using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ElementariaMod.Content.Items.Materials.ElementalGlobes
{
	public class FireGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fire Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Fire Elemental Core");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 5));

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;

			Item.maxStack = 999;
			Item.value = 100;

			Item.rare = ItemRarityID.Red;
		}
	}
}