using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ElementariaMod.Common;

namespace ElementariaMod.Content.Buffs.Buffs
{
    public class HallowBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glowing Essance");
            Description.SetDefault("Light shines upon you.");
            Main.debuff[Type] = true; 
            Main.pvpBuff[Type] = true; 
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            int dust = Dust.NewDust(npc.position, npc.width, npc.height, DustID.YellowTorch);
            Main.dust[dust].scale = 1.9f;
            Main.dust[dust].velocity *= 3f;
            Main.dust[dust].noGravity = true;
        }
    }
}
