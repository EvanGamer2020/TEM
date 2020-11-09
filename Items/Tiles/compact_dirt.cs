using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TEM.Items.Tiles
{
    public class compact_dirt : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileValue[Type] = 10;
            Main.tileBlockLight[Type] = true;

            drop = mod.ItemType("compact_dirt");
        }

    }
}
