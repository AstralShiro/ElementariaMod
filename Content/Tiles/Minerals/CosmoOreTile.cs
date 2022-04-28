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
	public class CosmoOreTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 290;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cosmo Ore");
			AddMapEntry(new Color(255, 155, 55), name);

			DustType = 232;
			ItemDrop = ModContent.ItemType<Content.Items.Minerals.AncestralBiome.CosmoOre>();
			SoundStyle = 1;
			SoundType = SoundID.Tink;
			MinPick = 80;
		}
	}
	public class CosmoOreSystem : ModSystem
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));

			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new CosmoOrePass("Cosmo Ore", 150f));
			}
		}
	}
	public class CosmoOrePass : GenPass
	{
		public CosmoOrePass(string name, float loadWeight) : base(name, loadWeight)
		{ 
		}
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
			progress.Message = "Generating Cosmo Minerals";
			for (int k = 0; k < (int)(Main.maxTilesY * Main.maxTilesY * 6E-05); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(1, 15), WorldGen.genRand.Next(1, 15), ModContent.TileType<CosmoOreTile>());
			}
		}
	}
}