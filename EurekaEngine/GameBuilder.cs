using System;
using System.Collections.Generic;

namespace EurekaEngine
{
    public sealed class GameBuilder : IGameBuilder
    {
        private Dictionary<Type, object> _components = new Dictionary<Type, object>();

        public void SetComponent<ComponentInterface>(ComponentInterface component)
        {
            var interfaces = component.GetType().GetInterfaces();

            foreach (var intf in interfaces)
            {
                _components[intf] = component;
            }
        }

        public T GetImpl<T>()
        {
            var type = typeof(T);
            return (T)_components[type];
        }
    }
}
