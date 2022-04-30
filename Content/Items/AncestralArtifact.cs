using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Items
{
    public class AncestralArtifact : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancestral Artifcat");
            Tooltip.SetDefault("Use it for craft female vanities\n-Dev Stuff");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 29;

            ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory
            ItemID.Sets.ItemNoGravity[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;

            Item.rare = ModContent.RarityType<AncestralModRarity>();
            Item.value = Item.sellPrice(gold: 1);
            Item.maxStack = 29;
        }
    }
}