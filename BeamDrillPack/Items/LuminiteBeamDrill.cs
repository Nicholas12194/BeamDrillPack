using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class LuminiteBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Luminite Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Vaporizes anything in its path.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 45;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 500;
            item.axe = 100;
            item.tileBoost = 50;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,("LaserBeamDrill"));
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}