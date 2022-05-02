using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

using ElementariaMod.Content.Projectiles.PetsProj;

namespace ElementariaMod.Content.Buffs.PetBuffs
{
    public class MarshyButterflyBuff : ModBuff
    {

        public override void SetStaticDefaults()
        {   
            DisplayName.SetDefault("Marshy Butterfly");
            Description.SetDefault("Pet - Marshy Butterfly.");

            Main.buffNoTimeDisplay[Type] = true;
            Main.lightPet[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;

            int projType = ModContent.ProjectileType<MarshyButterflyProj>();

            if (player.whoAmI == Main.myPlayer && player.ownedProjectileCounts[projType] <= 0)
            {
                //var entitySource = player.GetProjectileSource_Buff(buffIndex);

                //Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, projType, 0, 0f, player.whoAmI);
            }
        }
    }
}