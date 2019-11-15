using System.Data.Entity;
using Ninject.Web.Common;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Services.Data;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.Services;

namespace SimpleWebShop.Web
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Ninject;

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            this.AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return this.kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            // register services and bindings
            kernel.Bind<DbContext>().To<ApplicationDbContext>();
            kernel.Bind(typeof(IDbRepository<>)).To(typeof(DbRepository<>)).InRequestScope();
            
            //services
            kernel.Bind<IUsersServices>().To<UsersServices>().InRequestScope();
            kernel.Bind<IProductsControlPanelServices>().To<ProductsControlPanelServices>().InRequestScope();
            kernel.Bind<ICategoriesServices>().To<CategoriesServices>().InRequestScope();
            kernel.Bind<IAdminCategoriesServices>().To<AdminCategoriesServices>().InRequestScope();
        }
    }
}