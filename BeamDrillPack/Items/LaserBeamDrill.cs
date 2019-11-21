using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class LaserBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Laser Drill Tier
            // DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Everything.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 35;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 230;
            item.axe = 30;
            item.tileBoost = 40;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("ChlorophyteBeamDrill"));
            recipe.AddIngredient(ItemID.LaserDrill, 1);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}