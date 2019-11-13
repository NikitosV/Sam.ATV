using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using Sitecore.Pipelines;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Sam.Foundation.IoC.Pipelines.InitializeContainer
{
    public class InitializeContainer
    {
        public void Process(PipelineArgs args)
        {
            var container = new Container();
            var containerArgs = new InitializeContainerArgs(container);

            CorePipeline.Run("initializeContainer", containerArgs);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                 .Where(a =>
                 a.FullName.StartsWith("Sam.Feature.") ||
                 a.FullName.StartsWith("Sam.Project.") ||
                 a.FullName.StartsWith("Sam.Foundation.")
            );

            container.RegisterMvcControllers(assemblies.ToArray());
            container.RegisterMvcIntegratedFilterProvider();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}