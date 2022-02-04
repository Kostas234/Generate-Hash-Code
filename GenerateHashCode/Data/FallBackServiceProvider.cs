using System;

namespace GenerateHashCode.Data
{
    public class FallBackServiceProvider : IServiceProvider
    {
        public object GetService(Type serviceType)
        {
            return new DummyService();
        }
    }

    public class DummyService { };
}
