using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using ElementariaMod.Content.NPCs.AncestralBiome.Critters;

namespace ElementariaMod.Content.Items.Critters.AncestralCritters
{
    internal class CosmoBuggy : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Buggy");
		}

            public override void SetDefaults() {
                Item.useStyle = ItemUseStyleID.Swing;
                //item.autoReuse = true;
                //item.useTurn = true;
                //item.useAnimation = 15;
                //item.useTime = 10;
                //item.maxStack = 999;
                Item.consumable = true;
                Item.width = 22;
                Item.height = 16;

                Item.noUseGraphic = true;

                //item.CloneDefaults(ItemID.);
                //item.bait = 17;
                Item.makeNPC = (short)ModContent.NPCType<CosmoBuggyNPC>();
            }
        }
    }