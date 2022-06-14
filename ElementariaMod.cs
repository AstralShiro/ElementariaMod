using Terraria.ModLoader;
using ElementariaMod.Common;

namespace ElementariaMod
{
    public class ElementariaMod : Mod
    {
        public static string AssetPath { get; internal set; }
    }

     public override void Unload()
     {
          ElementLists.UnloadLists();
     }

     public override void Load()
     {
          ElementLists.UnloadLists();
     }
}
