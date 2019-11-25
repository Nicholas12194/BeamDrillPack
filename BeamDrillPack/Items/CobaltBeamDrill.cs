using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class CobaltBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Palladium Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Mythral and Oricalcum.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 15;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 130;
            item.axe = 0;
            item.tileBoost = 15;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,("HellstoneBeamDrill"));
            recipe.AddIngredient(ItemID.CobaltBar, 18);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}