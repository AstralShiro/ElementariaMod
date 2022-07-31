using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

using ElementariaMod.Common;
using ElementariaMod.Content.Projectiles.Weapons.Custom.Swords;
using Terraria.Audio;

namespace ElementariaMod.Content.Items.Weapons.Custom.Sword
{
    class ScarletSword : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = Item.height = 72;
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
            Item.UseSound = SoundID.Item1;
        }

        /*public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (ElementLists.fireEnemies.Contains(target.type))
            {
                damage = (int)(damage * 1.8f);
            }
        }*/
    }
}
