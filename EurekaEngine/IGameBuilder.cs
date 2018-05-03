using System;

namespace EurekaEngine
{
    public interface IGameBuilder
    {
        void SetComponent<ComponentInterface>(ComponentInterface component);
        T GetImpl<T>();
    }
}
