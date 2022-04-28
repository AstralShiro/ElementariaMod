using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

using ElementariaMod.Content.Rarities;

namespace ElementariaMod.Content.Rarities
{
	public class ArcanumHigherTierModRarity : ModRarity
	{
		public override Color RarityColor => new(Main.DiscoR / 2, (byte)(Main.DiscoG / 1.25f), (byte)(Main.DiscoB / 1.5f));

		public override int GetPrefixedRarity(int offset, float valueMult) {
			if (offset < 0) { // If the offset is -1 or -2 (a negative modifier).
				return ModContent.RarityType<AncestralModRarity>(); // Make the rarity of items that have this rarity with a negative modifier the lower tier one.
			}

			return Type; // no 'higher' tier to go to, so return the type of this rarity.
		}
	}
}
