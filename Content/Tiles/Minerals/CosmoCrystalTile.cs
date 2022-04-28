using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;

namespace ElementariaMod.Content.Tiles.Minerals
{
	public class CosmoCrystalTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;		// The tile will be affected by spelunker highlighting
			//Main.tileValue[Type] = 310;           // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true;			// Modifies the draw color slightly.
			Main.tileShine[Type] = 1500;			// How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cosmo Crystal");
			AddMapEntry(new Color(255, 155, 55), name);

			DustType = 232;
			ItemDrop = ModContent.ItemType<Content.Items.Minerals.AncestralBiome.CosmoCrystal>();
			SoundStyle = 1;
			SoundType = SoundID.Tink;
			MinPick = 80;
		}
	}
	public class CosmoCrystalSystem : ModSystem
	{
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if(ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new CosmoCrystalPass("Cosmo Crystal", 150f));
            }
        }
    }
	public class CosmoCrystalPass : GenPass
    {
        public CosmoCrystalPass(string name, float loadWeight) : base(name, loadWeight)
        {
        }
        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
			progress.Message = "Generating Cosmo Minerals";
			for (int k = 0; k < (int)(Main.maxTilesY * Main.maxTilesY * 6E-05); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 15), WorldGen.genRand.Next(3, 5), ModContent.TileType<CosmoCrystalTile>());
            }
        }
    }
}