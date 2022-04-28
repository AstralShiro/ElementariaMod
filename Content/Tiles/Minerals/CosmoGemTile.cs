using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;
using Terraria.IO;

namespace ElementariaMod.Content.Tiles.Minerals
{
	public class CosmoGemTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;		// The tile will be affected by spelunker highlighting
			//Main.tileValue[Type] = 200;           // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true;			// Modifies the draw color slightly.
			Main.tileShine[Type] = 1000;			// How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Ice Gem");
			AddMapEntry(new Color(70, 255, 255), name);

			DustType = 232;
			ItemDrop = ModContent.ItemType<Content.Items.Minerals.AncestralBiome.CosmoGem>();
			SoundStyle = 1;
			SoundType = SoundID.Tink;
			MinPick = 80;
		}
	}
	public class CosmoGemSystem : ModSystem
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new CosmoGemPass("Cosmo Gem", 150f));
			}
		}
	}
	public class CosmoGemPass : GenPass
	{
		public CosmoGemPass(string name, float loadWeight) : base(name, loadWeight)
		{
		}
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			progress.Message = "Generating Cosmo Minerals";
			for (int k = 0; k < (int)(Main.maxTilesY * Main.maxTilesY * 6E-05); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), ModContent.TileType<CosmoOreTile>());
			}
		}
	}
}
