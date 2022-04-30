using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using ElementariaMod.Content.NPCs.AncestralBiome.Critters;

namespace ElementariaMod.Content.Items.Critters.AncestralCritters
{
    internal class CosmoBunny : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Bunny");
		}

            public override void SetDefaults() {
                Item.useStyle = ItemUseStyleID.Swing;
                //item.autoReuse = true;
                //item.useTurn = true;
                //item.useAnimation = 15;
                //item.useTime = 10;
                //item.maxStack = 999;
                Item.consumable = true;
                Item.width = 28;
                Item.height = 26;
                //item.makeNPC = 360;
                Item.noUseGraphic = true;
                //item.bait = 15;

                //item.CloneDefaults(ItemID.);
                //item.bait = 17;
                Item.makeNPC = (short)ModContent.NPCType<CosmoBunnyNPC>();
            }
        }
    }