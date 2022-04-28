using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ElementariaMod.Content.Items.Placeable.CraftingStation
{
	public class ElementalPedestal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elemental Pedestal");
			Tooltip.SetDefault("Crafting station for craft Elemental Cores");
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 14;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = TileType<Content.Tiles.CraftingStation.ElementalPedestalTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.StoneBlock, 15)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}