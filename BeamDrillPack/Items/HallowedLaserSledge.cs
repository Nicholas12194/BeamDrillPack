using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack.Items
{
	public class HallowedLaserSledge : ModItem
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
            item.axe = 30;
            item.hammer = 100;
            item.tileBoost = 30;


        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, ("MeteorLaserSledge"));
            recipe.AddIngredient(ItemID.Pwnhammer);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}