using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class LizharditeBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lizhardite Bar");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 24;
			item.value = 2000;
			item.rare = 8;
			item.maxStack = 99;
		}
	}
}