namespace Teleimot.Web.Api
{
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;
    using Data;
    using Data.Repositories;
    using Services.Data;

    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ITeleimotDbContext>().To<TeleimotDbContext>();
            kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));
            kernel.Bind<IRealEstatesService>().To<RealEstatesService>();
        }
    }
}