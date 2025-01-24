using AdvantageAI_Server;
using AdvantageAI_Web;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace Unity
{
    internal class WebApi
    {
        internal class UnityDependencyResolver : IDependencyResolver
        {
            private IUnityContainer container;

            public UnityDependencyResolver(UnityWebApiActivator.IUnityContainer container)
            {
            }

            public UnityDependencyResolver(IUnityContainer container)
            {
                this.container = container;
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