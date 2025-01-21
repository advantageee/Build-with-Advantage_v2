using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace Unity
{
    internal class WebApi
    {
        internal class UnityDependencyResolver : IDependencyResolver
        {
            public UnityDependencyResolver(IUnityContainer container)
            {
            }

            public IDependencyScope BeginScope()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public object GetService(Type serviceType)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                throw new NotImplementedException();
            }
        }
    }
}