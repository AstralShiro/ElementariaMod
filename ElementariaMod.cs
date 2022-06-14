using Terraria.ModLoader;

namespace ElementariaMod
{
    public class ElementariaMod : Mod
    {
        public static string AssetPath { get; internal set; }
    }
     public override void Unload()
	 {
		    Mod = null;
            ElementList.UnloadLists();
	 }
}
