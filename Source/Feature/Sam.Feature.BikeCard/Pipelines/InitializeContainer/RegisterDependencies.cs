using Sam.Feature.BikeCard.Areas.BikeCard.Services;
using Sam.Foundation.IoC.Pipelines.InitializeContainer;

namespace Sam.Feature.BikeCard.Pipelines.InitializeContainer
{
    public class RegisterDependencies
    {
        public void Process(InitializeContainerArgs args)
        {
            args.Container.Register<IBikeCardService, BikeCardService>();
        }
    }
}