using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class Volcanite : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 825;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = true;
			Main.tileBlendAll[Type] = true;
			drop = mod.ItemType("VolcaniteOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Volcanite");
			AddMapEntry(new Color(200, 0, 0), name);
			mineResist = 4f;
			minPick = 225;
			dustType = mod.DustType("VolcaniteDust");
		}
	}
}