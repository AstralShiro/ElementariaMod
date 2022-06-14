using Terraria.ModLoader;
using ElemenrariaMod.Common;

namespace ElementariaMod
{
    public class ElementariaMod : Mod
    {
        public static string AssetPath { get; internal set; }
    }

     public override void Unload()
     {
          ElementList.UnloadLists();
     }
}
