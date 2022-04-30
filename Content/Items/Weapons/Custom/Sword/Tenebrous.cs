using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using ElementariaMod.Content.Projectiles.Weapons.Custom.Swords;
using Terraria.Audio;

namespace ElementariaMod.Content.Items.Weapons.Custom.Sword
{
	class Tenebrous : ModItem
	{

        public override void SetDefaults()
		{
			Item.width = Item.height = 54;
            Item.damage = 15;
            Item.DamageType = DamageClass.Melee;
            Item.knockBack = 4;
            Item.crit = 10;
            Item.useAnimation = 25;
            Item.useTime = 25;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 8f;
            Item.rare = ItemRarityID.Purple;
            Item.autoReuse = true;
			Item.useTurn = false;

            Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Assets/Sounds/Items/DarkMagicSound");


            Item.shoot = ModContent.ProjectileType<TenebrousProj>();
		}
    }
}