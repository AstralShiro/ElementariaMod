using Terraria;
using Terraria.ModLoader;

namespace ElementariaMod.Buffs.Debuffs
{
	public class AirDebuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Air Debuff");
			Description.SetDefault("Decrease the movement speed");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			if (!npc.boss) 
			{
				npc.velocity.X *= 0f;
				npc.velocity.Y *= 0f;
			}
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed *= 0.1f;
		}
	}
}