using SimpleInjector;
using Sitecore.Pipelines;

namespace Sam.Foundation.IoC.Pipelines.InitializeContainer
{
    public class InitializeContainerArgs : PipelineArgs
    {
        public Container Container { get; set; }

        public InitializeContainerArgs(Container container)
        {
            this.Container = container;
        }
    }
}