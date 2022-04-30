using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Buffs.PetBuffs;
using ElementariaMod.Content.Projectiles.PetsProj;

namespace ElementariaMod.Content.Pets.LightPets
{
	public class MarshyButterfly : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marshy butterfly");
			Tooltip.SetDefault("Summons a blue and white butterfly");
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Fish);
			Item.shoot = ModContent.ProjectileType<MarshyButterflyProj>();
			Item.buffType = ModContent.BuffType<MarshyButterflyBuff>();
			Item.UseSound = SoundID.NPCDeath6;
			Item.rare = ItemRarityID.Expert;
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(Item.buffType, 3600);
			}
		}
	}
}