﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Projectiles.Weapons.Custom.Swords
{
	class TenebrousProj : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tenebrous");
		}
		public override void SetDefaults()
		{
			Projectile.width = Projectile.height = 2;
			Projectile.aiStyle = 118;
			Projectile.friendly = true;

			Projectile.extraUpdates = 100;
			Projectile.penetrate = -1;
			Projectile.timeLeft = 200;

			Projectile.damage = 15;
			
		}
		public override void AI()
		{
			Projectile.localAI[0] += 1f;
			if (Projectile.localAI[0] > 9f)
			{
				for (int i = 0; i < 4; i++)
				{
					Vector2 projectilePosition = Projectile.position;
					projectilePosition -= Projectile.velocity * ((float)i * 0.25f);
					Projectile.alpha = 255;
					// Important, changed 173 to 178!
					int dust = Dust.NewDust(projectilePosition, 1, 1, DustID.ShadowbeamStaff, 0f, 0f, 0, default, 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].position = projectilePosition;
					Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
					Main.dust[dust].velocity *= 0.2f;
				}
			}
		}
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

		}

        public override void Kill(int timeLeft)
        {

        }
	}
}