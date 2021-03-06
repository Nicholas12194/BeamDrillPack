using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeamDrillPack
{
    public class CopperBeamDrill : ModItem
    {

        public override void SetStaticDefaults()
        {
            // Tin Tier
            // DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Can Mine Gold and Platinum.");
        }

        public override void SetDefaults()
        {

            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 1;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 40;
            item.axe = 0;
            item.tileBoost = 3;

        }

        public override void AddRecipes()
        {

            if (Config.EasyMode)
            {
                ModRecipe recipe = new ModRecipe(mod); //if you're using this inside a ModItem class, replace "this" with "mod".
                recipe.AddIngredient(ItemID.CopperPickaxe);
                recipe.AddIngredient(ItemID.Glowstick);
                recipe.AddIngredient(ItemID.Lens);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(mod, ("CopperBeamDrill"));
                recipe.AddRecipe();
            }

        }

    }



    public class TinBeamDrill : ModItem
    {

        public override void SetStaticDefaults()
        {
            // Tin Tier
            // DisplayName.SetDefault("Beam Drill"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Can Mine Gold and Platinum.");
        }

        public override void SetDefaults()
        {

            item.CloneDefaults(ItemID.LaserDrill);
            item.damage = 1;
            item.useTime = 0;
            item.useAnimation = 0;
            item.pick = 40;
            item.axe = 0;
            item.tileBoost = 3;

        }

        public override void AddRecipes()
        {

            if (Config.EasyMode)
            {
                ModRecipe recipe = new ModRecipe(mod); //if you're using this inside a ModItem class, replace "this" with "mod".
                recipe.AddIngredient(ItemID.TinPickaxe);
                recipe.AddIngredient(ItemID.Glowstick);
                recipe.AddIngredient(ItemID.Lens);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(mod, ("TinBeamDrill"));
                recipe.AddRecipe();
            }

        }

    }

}