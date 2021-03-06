﻿using System.Threading;

namespace EurekaEngine
{
    public class EurekaGame
    {
        private Thread _mainLoopThread;
        private ManualResetEvent _endMainGameLoop = new ManualResetEvent(false);
        private static IInputManager _inputManager;
        private static IOutputManager _outputManager;
        private static IDrawLoopExecutor _drawLoopExecutor;
        private static IGameBuilder _builder;

        public void Init(IRegistrator registrator)
        {
            _builder = new GameBuilder();
            registrator.Register(_builder);
            _inputManager = _builder.GetImpl<IInputManager>();
            _outputManager = _builder.GetImpl<IOutputManager>();
            _drawLoopExecutor = _builder.GetImpl<IDrawLoopExecutor>();
        }

        public void Start()
        {
            _mainLoopThread = new Thread(MainLoop);
            _mainLoopThread.Start();
            _endMainGameLoop.WaitOne();
        }

        private void MainLoop()
        {
            while (true)
            {
				_drawLoopExecutor.ExecuteDrawLoop();
            }

            _endMainGameLoop.Set();
        }
    }
}
