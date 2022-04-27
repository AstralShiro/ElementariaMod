using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace ElementariaMod.Content.Items.Materials.ElementalGlobes
{
	public class AirGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Air Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Air Elemental Core");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 9));

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;

			Item.maxStack = 99;
			Item.value = 100;

			Item.rare = ItemRarityID.White;
		}
	}
}