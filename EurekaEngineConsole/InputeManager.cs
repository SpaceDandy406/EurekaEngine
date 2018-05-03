using EurekaEngine;
using System;

namespace EurekaEngineConsole
{
    class InputManager : IInputManager
    {
        public bool IsKeyPressed(ConsoleKey key)
        {
            var k = Console.ReadKey();

            return k.Key == key;
        }
    }
}
