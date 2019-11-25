using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class OrichalcumBeamDrill : ModItem
	{
		public override void SetStaticDefaults() 
		{
            // Titanium Tier
			// DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Can Mine Adamantite and Titanium.");
		}

		public override void SetDefaults() 
		{
            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 18;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 190;
            item.axe = 0;
            item.tileBoost = 20;


        }

		public override void AddRecipes() 
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("CobaltBeamDrill"));
            recipe.AddIngredient(ItemID.OrichalcumBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("PalladiumBeamDrill"));
            recipe.AddIngredient(ItemID.OrichalcumBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}