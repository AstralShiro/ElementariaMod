using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

using ElementariaMod.Content.Projectiles.PetsProj;
using ElementariaMod.Content.Buffs.PetBuffs;

namespace ElementariaMod.Content.Pets.LightPets
{
	public class ShiroButterfly : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiro butterfly");
			Tooltip.SetDefault("Summons a light blue and pink butterfly");
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Fish);
			Item.shoot = ModContent.ProjectileType<ShiroButterflyProj>();
			Item.buffType = ModContent.BuffType<ShiroButterflyBuff>();
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