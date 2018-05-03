namespace EurekaEngine
{
    public static class EurekaGame
    {
        private static IInputManager _inputManager;
        private static IOutputManager _outputManager;
        private static IGameBuilder _builder;

        public static void Init(IRegistrator registrator)
        {
            _builder = new GameBuilder();
            registrator.Register(_builder);
            _inputManager = _builder.GetImpl<IInputManager>();
            _outputManager = _builder.GetImpl<IOutputManager>();
        }

        public static void Start()
        {
            while(true)
            {
            }
        }
    }
}
