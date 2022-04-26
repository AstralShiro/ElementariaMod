using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Minerals
{
	public class StoneFragment : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stone Fragment");
			Tooltip.SetDefault("A simple stone fragment, used for create a elemental stones");
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes()
		{
			CreateRecipe(999)
				.AddIngredient(ItemID.StoneBlock, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}