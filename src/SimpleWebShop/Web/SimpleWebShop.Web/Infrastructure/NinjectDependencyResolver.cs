using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Ninject.Web.Common;

namespace SimpleWebShop.Web.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);

        }

        private void AddBindings()
        {
            //kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //register services and bindings
            kernel.Bind<ISomeService>().To<SomeService>().InRequestScope();
        }
    }

    public interface ISomeService
    {
        void Work();
    }

    public class SomeService : ISomeService
    {
        public void Work()
        {
            Trace.WriteLine("I am working");
        }
    }
}