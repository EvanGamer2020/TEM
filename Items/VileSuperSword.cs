using Mono.Cecil;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace TEM.Items
{
	public class VileSuperSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SuperSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("CHEAT -- The Best Sword In All The Land. Kills NPCS");
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

        public override bool? CanHitNPC(Player player, NPC target)
        {
			//return base.CanHitNPC(player, target);
			return true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe.AddIngredient(null, "SuperSword");
			recipe.AddIngredient(ItemID.VilePowder);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe2.AddIngredient(null, "VileSuperSword");
			recipe2.AddIngredient(ItemID.PurificationPowder);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.SetResult(null, "SuperSword");
			recipe2.AddRecipe();
		}
	}
}