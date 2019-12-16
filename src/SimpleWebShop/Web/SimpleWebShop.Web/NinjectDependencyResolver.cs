using System.Data.Entity;
using AutoMapper;
using Ninject.Web.Common;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.Services;
using SimpleWebShop.Web.Areas.Administration.ViewModels;

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


            //inject AutoMapper
            var mapperConfiguration = CreateConfiguration();
            kernel.Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

            //// This teaches Ninject how to create automapper instances say if for instance
            //// MyResolver has a constructor with a parameter that needs to be injected
            kernel.Bind<IMapper>().ToMethod(ctx =>
                new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));


            //services
            kernel.Bind<IUsersServices>().To<UsersServices>().InRequestScope();
            kernel.Bind<IProductsControlPanelServices>().To<ProductsControlPanelServices>().InRequestScope();
            kernel.Bind<ICategoriesServices>().To<CategoriesServices>().InRequestScope();
            kernel.Bind<IAdminCategoriesServices>().To<AdminCategoriesServices>().InRequestScope();


        }

        //AutoMapper Configurations - here can add some configurations
        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateCategoryInputModel,ProductCategory>();
            });

            return config;
        }
    }
}