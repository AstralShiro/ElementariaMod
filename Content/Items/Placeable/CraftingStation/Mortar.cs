using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using Elementaria.Tiles.CraftingStation;

namespace Elementaria.Items.Placeable.CraftingStation
{
	public class Mortar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mortar");
			Tooltip.SetDefault("It is used to create the powders");
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 26;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<MortarTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EmptyWorkTable>(), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
;			recipe.AddRecipe();
		}
	}
}