using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EurekaEngine.Utils
{
    internal static class IntJuggler
    {
        /// <summary>
        /// Only if Lengths the same
        /// </summary>
        /// <param name="sourceArr"></param>
        /// <param name="destArr"></param>
        public unsafe static void Copy(ref int[] sourceArr, ref int[] destArr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                destArr[i] = sourceArr[i];
            }
        }
    }
}
