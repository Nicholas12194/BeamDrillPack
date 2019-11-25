using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class LuminiteLaserSledge : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Laser Drill Tier
            // DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Pound it!");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.width = 52;
            item.height = 22;
            item.damage = 45;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 0;
            item.axe = 100;
            item.hammer = 500;
            item.tileBoost = 50;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("HallowedLaserSledge"));
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}