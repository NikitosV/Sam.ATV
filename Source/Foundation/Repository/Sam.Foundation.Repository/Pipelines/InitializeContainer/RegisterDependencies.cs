using Sam.Foundation.IoC.Pipelines.InitializeContainer;
using Sam.Foundation.Repository.Content;
using Sam.Foundation.Repository.Search;

namespace Sam.Foundation.Repository.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeContainerArgs args)
        {
            args.Container.Register<IContentRepository, SitecoreContentRepository>();
            args.Container.Register<ISearchRepository, SearchRepository>();
        }
    }
}