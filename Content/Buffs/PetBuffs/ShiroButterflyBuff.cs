using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

using ElementariaMod.Content.Projectiles.PetsProj;
 
namespace ElementariaMod.Content.Buffs.PetBuffs
{
    public class ShiroButterflyBuff : ModBuff
    {

        public override void SetStaticDefaults()
        {   
            DisplayName.SetDefault("Shiro Butterfly");
            Description.SetDefault("Pet - Shiro Butterfly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.lightPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;

            int projType = ModContent.ProjectileType<ShiroButterflyProj>();

            if (player.whoAmI == Main.myPlayer && player.ownedProjectileCounts[projType] <= 0)
            {
                var entitySource = player.GetProjectileSource_Buff(buffIndex);

                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, projType, 0, 0f, player.whoAmI);
            }
        }
    }
}