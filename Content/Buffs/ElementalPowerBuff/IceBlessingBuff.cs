using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementariaMod.Content.Buffs.ElementalPowerBuff
{
	public class IceBlessingBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ysdia's Blessing");
			Description.SetDefault("You have sworn allegiance to Ysdia, you have perfect control of the ice.\nYou : You get ice barrier, you will not broke the ice and you will have more stability.\nEnemy : You will apply fire when you hit enemies");
			Main.buffNoTimeDisplay[Type] = true;
			
			BuffID.Sets.LongerExpertDebuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.iceBarrier = true;
			player.iceSkate = true;

        }
    }
}