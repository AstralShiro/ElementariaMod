using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using ElementariaMod.Content.Buffs.PetBuffs;

namespace ElementariaMod.Content.Projectiles.PetsProj
{
    public class ShiroButterflyProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shiro Butterfly");
            Main.projFrames[Projectile.type] = 4;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.width = 22;
            Projectile.height = 20;
            Projectile.CloneDefaults(ProjectileID.ZephyrFish);
            AIType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            if (!player.dead && player.HasBuff(ModContent.BuffType<ShiroButterflyBuff>()))
            {
                Projectile.timeLeft = 2;
            }

            if (!Main.dedServ)
            {
                Lighting.AddLight(Projectile.Center, Projectile.Opacity * .5f, Projectile.Opacity * .5f, Projectile.Opacity * .5f);
            }
        }
    }
}
