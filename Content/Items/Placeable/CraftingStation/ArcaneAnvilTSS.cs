using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Items.Placeable.CraftingStation;
using ElementariaMod.Content.Items.Materials;

namespace ElementariaMod.Content.Items.Placeable.CraftingStation
{
	public class ArcaneAnvilTSS : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcane Anvil");
			Tooltip.SetDefault("Crafting station for craft the Weapons TSS");
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
			Item.createTile = TileType<Tiles.CraftingStation.ArcaneAnvilTSSTile>();
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ModContent.ItemType<ArcaneAnvilTS>(), 1)
				.AddIngredient(ModContent.ItemType<ArcanumHeart>(), 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}