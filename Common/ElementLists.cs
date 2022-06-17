using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Common
{
    public class ElementLists
    {
        public static List<int> fireEnemies;
        public static List<int> iceEnemies;

        public static void LoadLists()
        {
            fireEnemies = new List<int>
            {
                NPCID.LavaSlime,
                NPCID.VoodooDemon,
                NPCID.Lavabat,
                NPCID.RuneWizard,
                NPCID.RedDevil,
                NPCID.RaggedCaster,
                NPCID.SolarCorite,
                NPCID.SolarCrawltipedeHead,
                NPCID.SolarCrawltipedeBody,
                NPCID.SolarCrawltipedeTail,
                NPCID.SolarDrakomire,
                NPCID.SolarDrakomireRider,
                NPCID.DD2DrakinT2,
                NPCID.DD2DrakinT3,
                NPCID.SolarSroller,
                NPCID.SolarSolenian,
                NPCID.DD2Betsy,
                NPCID.MourningWood,
                NPCID.Pumpking,
                NPCID.LunarTowerSolar,
            };
            iceEnemies = new List<int>
            {
                NPCID.IceSlime,
                NPCID.ZombieEskimo,
                NPCID.CorruptPenguin,
                NPCID.CrimsonPenguin,
                NPCID.Deerclops,
                NPCID.IceElemental,
                NPCID.Wolf,
                NPCID.IceGolem,
                NPCID.Penguin,
                NPCID.IceBat,
                NPCID.SnowFlinx,
                NPCID.SpikedIceSlime,
                NPCID.UndeadViking,
                NPCID.UndeadMiner,
                NPCID.CyanBeetle,
                NPCID.Nymph,
                NPCID.ArmoredViking,
                NPCID.IceTortoise,
                NPCID.IcyMerman,
                NPCID.IceMimic,
                NPCID.PigronCorruption,
                NPCID.PigronCrimson,
                NPCID.PigronHallow,
            };
        }

        public static void UnloadLists()
        {
            fireEnemies = null;
            iceEnemies = null;
        }
    }
}
