using AdvantageAI_Server;
using AdvantageAI_Web;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using static AdvantageAI_Web.UnityWebApiActivator;

namespace Unity
{
    internal class WebApi
    {
        internal class UnityDependencyResolver : IDependencyResolver
        {
            private AdvantageAI_Web.IUnityContainer container;

            public UnityDependencyResolver(AdvantageAI_Server.UnityWebApiActivator.IUnityContainer container)
            {
                this.container = (AdvantageAI_Web.IUnityContainer)container;
            }

            public UnityDependencyResolver(AdvantageAI_Web.IUnityContainer container)
            {
                this.container = container;
            }

            public UnityDependencyResolver(AdvantageAI_Web.UnityWebApiActivator.IUnityContainer container1)
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