using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using ElementariaMod.Projectiles.PetsProj;
 
namespace ElementariaMod.Buffs.PetBuff
{
    public class ShiroButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Shiro Butterfly");
            Description.SetDefault("Pet - Shiro Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;

            int projType = ModContent.ProjectileType<ShiroButterflyProj>();

			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<ShiroButterflyProj>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<ShiroButterflyProj>(), 0, 0f, player.whoAmI);
			}
		}
    }
}