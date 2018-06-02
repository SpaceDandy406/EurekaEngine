using EurekaEngine;

namespace EurekaEngineConsole
{
	internal class Registrator : IRegistrator
	{
		public void Register(IGameBuilder builder)
		{
			builder.SetComponent<IInputManager>(new InputManager());
			builder.SetComponent<IOutputManager>(new OutputManager());
			builder.SetComponent<IDrawLoopExecutor>(new DrawLoopExecutor());
		}
	}
}
