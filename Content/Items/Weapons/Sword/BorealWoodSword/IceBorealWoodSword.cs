using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using ElementariaMod.Content.Projectiles.Weapons.Custom.Swords;
using Terraria.Audio;

namespace ElementariaMod.Content.Items.Weapons.Sword.BorealWoodSword
{
	class IceBorealWoodSword : ModItem
	{

        public override void SetDefaults()
		{
            Item.CloneDefaults(ItemID.BorealWoodSword);
		}
    }
}