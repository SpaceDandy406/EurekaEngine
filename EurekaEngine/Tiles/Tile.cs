using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EurekaEngine.Utils;

namespace EurekaEngine.Tiles
{
    internal class Tile
    {
        public static Tile Empty = new Tile();

        public int Size;
        public int[] TileSource;

        public Tile(ref int[] tileBytes, int size)
        {
            var length = tileBytes.Length;
            Size = size;
            TileSource = new int[length];
            IntJuggler.Copy(ref tileBytes, ref TileSource, length);
        }

        private Tile()
        {
            Size = 0;
            TileSource = new int[0];
        }
    }
}
