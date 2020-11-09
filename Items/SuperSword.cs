using Terraria.ID;
using Terraria.ModLoader;

namespace TEM.Items
{
	public class SuperSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SuperSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("CHEAT -- The Best Sword In All The Land.");
		}

		public override void SetDefaults() 
		{
			item.damage = 50000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SuperSword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}