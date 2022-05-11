using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System.Collections.Generic;

namespace ElementariaMod.Content.Items.Weapons.Sword.BeeKeeper
{
	class IceBeeKeeper : ModItem
	{

        public override void SetDefaults()
		{
            Item.CloneDefaults(ItemID.BeeKeeper);
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			TooltipLine Line = new(Mod, "Air Stone", "Air Element");
			Line.OverrideColor = new Color(255, 255, 255);
			tooltips.Add(Line);
		}
	}
}