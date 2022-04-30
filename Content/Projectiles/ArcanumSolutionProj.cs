using ElementariaMod.Content.Tiles.ArcanumBiome.ArcanumBlocks;
using ElementariaMod.Content.Walls.ArcanumBiome;
using ElementariaMod.Content.Dusts;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElementariaMod.Content.Projectiles
{
	public class ArcanumSolutionProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcanum Spray");
		}

		public override void SetDefaults()
		{
			Projectile.width = 6;
			Projectile.height = 6;
			Projectile.friendly = true;
			Projectile.alpha = 255;
			Projectile.penetrate = -1;
			Projectile.extraUpdates = 2;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;
		}

		public override void AI()
		{
			//Set the dust type to ExampleSolution
			int dustType = ModContent.DustType<ArcanumDust>();

			if (Projectile.owner == Main.myPlayer)
				Convert((int)(Projectile.position.X + Projectile.width / 2) / 16, (int)(Projectile.position.Y + Projectile.height / 2) / 16, 2);

			if (Projectile.timeLeft > 133)
				Projectile.timeLeft = 133;

			if (Projectile.ai[0] > 7f)
			{
				float dustScale = 1f;

				if (Projectile.ai[0] == 8f)
					dustScale = 0.2f;
				else if (Projectile.ai[0] == 9f)
					dustScale = 0.4f;
				else if (Projectile.ai[0] == 10f)
					dustScale = 0.6f;
				else if (Projectile.ai[0] == 11f)
					dustScale = 0.8f;

				Projectile.ai[0] += 1f;

				for (int i = 0; i < 1; i++)
				{
					int dustIndex = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, dustType, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 100);
					Dust dust = Main.dust[dustIndex];
					dust.noGravity = true;
					dust.scale *= 1.75f;
					dust.velocity.X *= 2f;
					dust.velocity.Y *= 2f;
					dust.scale *= dustScale;
				}
			}
			else
				Projectile.ai[0] += 1f;

			Projectile.rotation += 0.3f * Projectile.direction;
		}

		private static void Convert(int i, int j, int size = 15)
		{
			for (int k = i - size; k <= i + size; k++)
			{
				for (int l = j - size; l <= j + size; l++)
				{
					if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt((size * size) + (size * size)))
					{
						int type = Main.tile[k, l].TileType;
						int wall = Main.tile[k, l].WallType;

						// Convert all walls to ExampleWall
						if (wall != 0)
						{
							Main.tile[k, l].WallType = (ushort)ModContent.WallType<ArcanumDirtWall>();
							WorldGen.SquareWallFrame(k, l);
							NetMessage.SendTileSquare(-1, k, l, 1);
						}

						// If the tile is stone, convert to ExampleBlock
						if (type == TileID.Stone)
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumStoneTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-1, k, l, 1);
						}
						// If the tile is sand, convert to ExampleSand
						/*else if (TileID.Sets.Conversion.Sand[type])
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumSandTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-1, k, l, 1);
						}*/
						// If the tile is a chair, convert to ExampleChair
						if (type == TileID.Dirt)
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumDirtTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-0, k, l, 1);
						}
						
						if (type == TileID.ClayBlock)
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumDirtTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-0, k, l, 1);
                        }
						if (type == TileID.Mud)
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumDirtTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-0, k, l, 1);
						}

						if (type == TileID.Grass)
						{
							Main.tile[k, l].TileType = (ushort)ModContent.TileType<ArcanumGrassTile>();
							WorldGen.SquareTileFrame(k, l);
							NetMessage.SendTileSquare(-0, k, l, 1);
						}
					}
				}
			}
		}
	}
}
