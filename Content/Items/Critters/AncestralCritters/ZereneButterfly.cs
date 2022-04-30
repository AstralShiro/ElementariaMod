using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using ElementariaMod.Content.NPCs.AncestralBiome.Critters;

namespace ElementariaMod.Content.Items.Critters.AncestralCritters
{
    internal class ZereneButterfly : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Zerene Butterfly");
		}

            public override void SetDefaults() {
            Item.useStyle = ItemUseStyleID.Swing;
            //item.autoReuse = true;
            //item.useTurn = true;
            //item.useAnimation = 15;
            //item.useTime = 10;
            //item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 26;
            //item.makeNPC = 360;
            Item.noUseGraphic = true;
            //item.bait = 15;
            //item.CloneDefaults(ItemID.Butt);
             Item.bait = 17;
             Item.makeNPC = (short)ModContent.NPCType<ZereneButterflyNPC>();
        }
    }
}