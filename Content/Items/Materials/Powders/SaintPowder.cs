using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Minerals;
using ElementariaMod.Content.Tiles.CraftingStation;


namespace ElementariaMod.Content.Items.Materials.Powders
{

    public class SaintPowder : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Saint powder");
            Tooltip.SetDefault("Use it for craft the Saint Globe");
        }
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 14;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice(copper: 50);
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ModContent.ItemType<SaintStone>(), 1)
                .AddTile(ModContent.TileType<MortarTile>())
                .Register();
        }
    }
}