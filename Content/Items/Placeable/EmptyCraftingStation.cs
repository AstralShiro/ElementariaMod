using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Items.Placeable
{
    public class EmptyCraftingStation : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Work table");
            Tooltip.SetDefault("Principal item for craft the crafting stations");
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(copper: 50);
            Item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}