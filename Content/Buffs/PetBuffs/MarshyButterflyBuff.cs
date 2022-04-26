using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using ElementariaMod.Projectiles.PetsProj;
 
namespace ElementariaMod.Buffs.PetBuff
{
    public class MarshyButterflyBuff : ModBuff
    {

        public override void SetDefaults()
        {   
            DisplayName.SetDefault("Marshy Butterfly");
            Description.SetDefault("Pet - Marshy Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;

            int projType = ModContent.ProjectileType<MarshyButterflyProj>();

			bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<MarshyButterflyProj>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.Center, Vector2.Zero, ModContent.ProjectileType<MarshyButterflyProj>(), 0, 0f, player.whoAmI);
			}
		}
    }
}