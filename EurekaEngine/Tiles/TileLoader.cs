using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EurekaEngine.Tiles
{
    internal class TileLoader
    {
        public Tile LoadTile(string filePath)
        {
            if (!File.Exists(filePath))
                return Tile.Empty;

            var bitmap = Bitmap.FromFile(filePath);
            Bitmap.Get
        }
    }
}
