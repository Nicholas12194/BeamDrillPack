using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class GoldBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Platinum Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Demonite and Crimtane");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 2;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 59;
            item.axe = 12;
            item.tileBoost = 4;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,("TinBeamDrill"));
            recipe.AddIngredient(ItemID.GoldBar, 12);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("CopperBeamDrill"));
            recipe.AddIngredient(ItemID.GoldBar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}