using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class CrimsonBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Deathbringer Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Hellstone.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 5;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 70;
            item.axe = 15;
            item.tileBoost = 6;


        }

		public override void AddRecipes() 
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("GoldBeamDrill"));
            recipe.AddIngredient(ItemID.CrimtaneBar, 12);
            recipe.AddIngredient(ItemID.TissueSample, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("PlatinumBeamDrill"));
            recipe.AddIngredient(ItemID.CrimtaneBar, 12);
            recipe.AddIngredient(ItemID.TissueSample, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}