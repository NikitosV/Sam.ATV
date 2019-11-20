using Sam.ATV.Web.Areas.ATV.Logic.Services;
using Sam.Foundation.IoC.Pipelines.InitializeContainer;

namespace Sam.ATV.Web.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeContainerArgs args)
        {
            args.Container.Register<ISearchService, SearchService>();
        }
    }
}