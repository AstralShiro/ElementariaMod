using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementariaMod.Content.Buffs.ElementalPowerBuff
{
	public class AirBlessingBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yneas's Blessing");
			Description.SetDefault("You have sworn allegiance to Yneas, you have perfect control of the air.\nYou : Your movement, your jumps and your attacks will be faster\nEnemy : Movement speed decreased");
			Main.buffNoTimeDisplay[Type] = true;
			
			BuffID.Sets.LongerExpertDebuff[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			//Movement
			player.moveSpeed += 0.5f;
			//Attack speed
			player.GetAttackSpeed(GenericDamageClass.Generic) += 0.5f;
			//Jump
			player.jumpBoost = true;
			player.jumpSpeedBoost += 0.5f;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
			npc.velocity /= 0.5f;
        }
    }
}