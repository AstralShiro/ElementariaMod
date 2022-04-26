using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elementaria.Items.Materials.Minerals
{
	public class AirStone : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Air stone");
			Tooltip.SetDefault("A windy stone");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5,6));
		}

		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}
			public override void PostUpdate() {
			Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<StoneFragment>(), 10);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}