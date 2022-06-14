using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Common
{
    public class ElementLists
    {
        public static List<int> fireEnemies;

        public static void LoadLists()
        {
            fireEnemies = new List<int>()
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
        }

        public static void UnloadLists()
        {
            fireEnemies = null;
        }
    }
}
