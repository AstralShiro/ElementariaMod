using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElementariaMod.Content.Buffs.Debuffs
{
	public class DarkDebuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Debuff");
			Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;

			BuffID.Sets.LongerExpertDebuff[Type] = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			//npc.AddBuff(BuffID.Confused, buffIndex, true);
		}
	}
}