using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader.Assets;
using Microsoft.Xna.Framework;

using ElementariaMod.Content.Items.Placeable.AncestralBiome;
using ElementariaMod.Content.Gores;

namespace ElementariaMod.Content.Tiles.AncestralBiome.AncestralAmbient.AncestralTree
{
	public class AncestralTreeTile : ModTree
	{
        public override int CreateDust()
		{
			return 1;
		}

		public override int GrowthFXGore() {
			return ModContent.GoreType<AncestralTreeFX>();
		}

		public override int DropWood() {
			return ModContent.ItemType<AncestralWood>();
		}

		public override Texture2D GetTexture() {
			return (Texture2D)ModContent.Request<Texture2D>("ElementariaMod/Content/Tiles/AncestralBiome/AncestralAmbient/AncestralTree/AncestralTreeTile");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) 
		{
			return (Texture2D)ModContent.Request<Texture2D>("ElementariaMod/Content/Tiles/AncestralBiome/AncestralAmbient/AncestralTree/AncestralTreeTile_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return (Texture2D)ModContent.Request<Texture2D>("ElementariaMod/Content/Tiles/AncestralBiome/AncestralAmbient/AncestralTree/AncestralTreeTile_Branches");
		}
	}
} 