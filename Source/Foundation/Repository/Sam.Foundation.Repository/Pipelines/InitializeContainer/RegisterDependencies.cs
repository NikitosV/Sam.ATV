using Sam.Foundation.IoC.Pipelines.InitializeContainer;
using Sam.Foundation.Repository.Content;

namespace Sam.Foundation.Repository.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeContainerArgs args)
        {
            args.Container.Register<IContentRepository, SitecoreContentRepository>();
        }
    }
}