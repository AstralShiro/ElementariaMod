using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.CraftingStation;
using ElementariaMod.Content.Items.Materials;

namespace ElementariaMod.Content.Items.Placeable.CraftingStation
{
	public class ArcaneAnvilT4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Anvil");
			Tooltip.SetDefault("Crafting station for craft the Weapons T4");
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
			Item.createTile = TileType<Content.Tiles.CraftingStation.ArcaneAnvilT4Tile>();
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<ArcaneAnvilT3>(), 1)
				.AddIngredient(ModContent.ItemType<MoonLordHeart>(), 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}