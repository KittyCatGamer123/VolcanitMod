using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Npcs
{
	public class NovaFloatingStar : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Floating Star");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = 3;
			npc.lifeMax = 20;
			npc.damage = 25;
			npc.defense = 10;
			npc.knockBackResist = 0.1f;
			npc.width = 22;
			npc.height = 24;
			Main.npcFrameCount[npc.type] = 1;
			npc.npcSlots = 0.1f;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.netAlways = true;
			}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FloatingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FloatingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/FloatingStarFragment"), npc.scale);
			}
		}
	}
}