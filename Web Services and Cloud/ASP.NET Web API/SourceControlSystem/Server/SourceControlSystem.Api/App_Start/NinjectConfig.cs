[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SourceControlSystem.Api.App_Start.NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SourceControlSystem.Api.App_Start.NinjectConfig), "Stop")]

namespace SourceControlSystem.Api.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Extensions.Conventions;
    using Ninject;
    using Ninject.Web.Common;
    using SourceControl.Data.Services;
    using Data;

    public static class NinjectConfig 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
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

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel
                .Bind<IProjectsService>()
                .To<ProjectsService>()
                .InRequestScope();
           
            kernel.Bind(typeof(IRepository<>)).To(typeof(EfGenericRepository<>));

            kernel.Bind(b => b.From("SourceControl.Data.Services")
                .SelectAllClasses()
                .BindDefaultInterface());
        }        
    }
}
