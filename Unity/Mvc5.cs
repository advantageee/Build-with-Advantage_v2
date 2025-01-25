using AdvantageAI_Web;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Unity
{
    internal class Mvc5
    {
        internal class UnityDependencyResolver : IDependencyResolver
        {
            public UnityDependencyResolver(IUnityContainer container)
            {
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