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
                NPCID.VoodoDemon,
                NPCID.LavaBat,
                NPCID.RuneWizard,
                NPCID.RedDevil,
                NPCID.RaggedCaster,
                NPCID.Corite,
                NPCID.Crawltipide,
                NPCID.Drakomire,
                NPCID.DrakomireRider,
                NPCID.Drakanian,
                NPCID.Selenian,
                NPCID.Sroller,
                NPCID.Betsy,
                NPCID.MourningWood,
                NPCID.Pumpking,
                NPCID.SolarPillar,
            };
        }

        public static void UnloadLists()
        {
            fireEnemies = null;
        }
    }
}
