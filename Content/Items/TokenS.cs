using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Items
{
    public class TokenS : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Token S");
            Tooltip.SetDefault("Use it for craft male vanities\n-Dev Stuff-");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 29;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;

            Item.rare = ModContent.RarityType<ArcanumModRarity>();
            Item.value = Item.sellPrice(gold: 1);
            Item.maxStack = 29;
        }
    }
}
