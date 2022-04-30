using ElementariaMod.Content.Items;
using ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks;
using ElementariaMod.Content.Walls.ArcanumBiome;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

using ElementariaMod.Content.Projectiles;
using ElementariaMod.Content.Items.Materials.Powders;

namespace ElementariaMod.Content.Items
{
	public class ArcanumSolution : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Monochromatic Solution");
			Tooltip.SetDefault("Used by the Clentaminator\nSpreads the example");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults()
		{
			Item.shoot = ModContent.ProjectileType<ArcanumSolutionProj>() - ProjectileID.PureSpray;
			Item.ammo = AmmoID.Solution;
			Item.width = 10;
			Item.height = 12;
			Item.value = Item.buyPrice(0, 0, 25);
			Item.rare = ItemRarityID.Orange;
			Item.maxStack = 999;
			Item.consumable = true;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<CosmoPowder>()
				.AddIngredient(ItemID.Bottle)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}