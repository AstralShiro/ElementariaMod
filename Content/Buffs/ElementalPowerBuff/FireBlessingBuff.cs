using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementariaMod.Content.Buffs.ElementalPowerBuff
{
	public class FireBlessingBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mezdar's Blessing");
			Description.SetDefault("You have sworn allegiance to Mezdar, you have perfect control of the fire.\nYou : You are immune to lava and burned blocks\nEnemy : You will apply fire when you hit enemies");
			Main.buffNoTimeDisplay[Type] = true;
			
			BuffID.Sets.LongerExpertDebuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            //Movement
            player.AddBuff(BuffID.ObsidianSkin, buffIndex);
            player.lavaImmune = true;

			player.AddBuff(BuffID.WeaponImbueFire, buffIndex);
        }
    }
}