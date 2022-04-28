using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Tiles.CraftingStation;

namespace ElementariaMod.Content.Items.Placeable.CraftingStation
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
			Item.width = 38;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = TileType<MortarTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<EmptyCraftingStation>(), 1)
				.AddIngredient(ItemID.StoneBlock, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}