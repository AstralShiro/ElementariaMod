using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;
using Terraria.Audio;
using Terraria.ID;

using ElementariaMod.Content.Backgrounds;


namespace ElementariaMod
{
	public class ElementariaMenu : ModMenu
	{
		private const string menuAssetPath = "ElementariaMod/Assets/Textures/Menu"; // Creates a constant variable representing the texture path, so we don't have to write it out multiple times

		public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>($"{menuAssetPath}/Logo");

		//public override Asset<Texture2D> SunTexture => ModContent.Request<Texture2D>($"{menuAssetPath}/SNSun");

		//public override Asset<Texture2D> MoonTexture => ModContent.Request<Texture2D>($"{menuAssetPath}/SNMoon");

		public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/Moonshine");

		public override ModSurfaceBackgroundStyle MenuBackgroundStyle => ModContent.GetInstance<MenuSurfaceBackgroundStyle>();

		public override string DisplayName => "Elementaria Mod Menu";

		public override void OnSelected() {
			SoundEngine.PlaySound(SoundID.AbigailSummon); // Plays a thunder sound when this ModMenu is selected
		}

		public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor) {
			drawColor = Main.DiscoColor; // Changes the draw color of the logo
			return true;
		}
	}
}
