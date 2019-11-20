using Sam.Feature.TripCard.Areas.TripCard.Services;
using Sam.Foundation.IoC.Pipelines.InitializeContainer;

namespace Sam.Feature.TripCard.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeContainerArgs args)
        {
            args.Container.Register<ITripCardService, TripCardService>();
        }
    }
}