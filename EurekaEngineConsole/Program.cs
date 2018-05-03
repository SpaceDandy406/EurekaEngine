using EurekaEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EurekaEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EurekaGame.Init(new Registrator());
            EurekaGame.Start();
        }
    }
}
