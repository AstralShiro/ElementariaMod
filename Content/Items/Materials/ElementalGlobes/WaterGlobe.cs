using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

using ElementariaMod.Content.Items.Materials.Powders;

namespace ElementariaMod.Content.Items.Materials.ElementalGlobes
{
	public class WaterGlobe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Water Globe");
			Tooltip.SetDefault("The soul of a living being infused into a globe, second material to craft the Water Elemental Core");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 7));

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;

			Item.maxStack = 999;
			Item.value = 100;

			Item.rare = ItemRarityID.Green;
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<WaterPowder>(), 10)
				.AddTile(TileID.Solidifier)
				.Register();
		}
	}
}