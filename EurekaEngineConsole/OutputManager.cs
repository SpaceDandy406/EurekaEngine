using EurekaEngine;
using System;

namespace EurekaEngineConsole
{
    internal class OutputManager : IOutputManager
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}