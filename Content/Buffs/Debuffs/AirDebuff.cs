using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementariaMod.Content.Buffs.Debuffs
{
	public class AirDebuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Air Debuff");
			Description.SetDefault("Decrease the movement speed");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			
			BuffID.Sets.LongerExpertDebuff[Type] = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			if (!npc.boss) 
			{
				npc.velocity.X *= 0.1f;
				npc.velocity.Y *= 0.1f;
			}
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed *= 0.1f;
		}
	}
}