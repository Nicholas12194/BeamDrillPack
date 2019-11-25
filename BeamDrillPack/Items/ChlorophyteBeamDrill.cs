using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class ChlorophyteBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Picksaw Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Lizhard Brick.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 28;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 210;
            item.axe = 0;
            item.tileBoost = 30;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,("HallowedBeamDrill"));
            recipe.AddIngredient(ItemID.BeetleHusk, 4);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}