using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Items.Artifacts
{
    public class IceArtifact : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Token N");
            Tooltip.SetDefault("Use it for craft female vanities\n-Dev Stuff");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 29;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;

            Item.rare = ModContent.RarityType<AncestralModRarity>();
            Item.value = Item.sellPrice(gold: 1);
            Item.maxStack = 29;
            Item.consumable = true;
        }
    }
}