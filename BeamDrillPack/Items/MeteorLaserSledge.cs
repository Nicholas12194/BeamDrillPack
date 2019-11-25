using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class MeteorLaserSledge : ModItem
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
            item.damage = 35;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 0;
            item.axe = 20;
            item.hammer = 60;
            item.tileBoost = 10;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 20);
            recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddIngredient(ItemID.Lens);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}