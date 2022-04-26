using Terraria;
using Terraria.ModLoader;

namespace ElementariaMod.Buffs.MountBuff
{
	public class FireWolfBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Fire Wolf");
			Description.SetDefault("You are blessed from the moon.");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.FireWolf>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
