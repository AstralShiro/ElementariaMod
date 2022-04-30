using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using ElementariaMod.Content.Items.Critters.AncestralCritters;
using Terraria.ModLoader.Utilities;

namespace ElementariaMod.Content.NPCs.AncestralBiome.Critters
{
	/// <summary>
	/// This file shows off a critter NPC. The unique thing about critters is how you can catch them with a bug net.  
	/// The important bits are: Main.NPCCatchable, NPC.catchItem, and item.makeNPC
	/// We will also show off adding an item to an existing RecipeGroup (see ExampleMod.AddRecipeGroups)
	/// </summary>
	internal class CosmoBuggyNPC : ModNPC
	{
			public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cosmo Buggy");
			Main.npcFrameCount[NPC.type] = 4;
		}

		public override void SetDefaults() {
			NPC.width = 18;
			NPC.height = 18;
			NPC.damage = 0;
			NPC.defense = 0;
			NPC.lifeMax = 5;
			NPC.dontCountMe = true;
			NPC.HitSound = SoundID.NPCHit3;
			NPC.DeathSound = SoundID.NPCDeath4;
			Main.npcCatchable[NPC.type] = true;
			NPC.catchItem = (short)ModContent.ItemType<CosmoBuggy>();
			NPC.knockBackResist = .45f;
			NPC.aiStyle = NPCID.Buggy;
			NPC.npcSlots = 0;
			NPC.friendly = true;
			NPC.dontTakeDamageFromHostiles = false;
			NPC.noGravity = false;
			AnimationType = NPCID.Buggy;
			AIType = NPCID.Buggy;
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Overworld.Chance * 0.1f;
		}

		public override void AI()
		{
			NPC.spriteDirection = NPC.direction;
		}
		public override void FindFrame(int frameHeight)
		{
			NPC.frameCounter += 0.15f;
			NPC.frameCounter %= Main.npcFrameCount[NPC.type];
			int frame = (int)NPC.frameCounter;
			NPC.frame.Y = frame * frameHeight;
		}
	}
}