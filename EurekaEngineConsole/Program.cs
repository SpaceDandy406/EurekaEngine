using EurekaEngine;

namespace EurekaEngineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new EurekaGame();
            game.Init(new Registrator());
            game.Start();
        }
    }
}
