using Sam.Feature.BikeCard.Areas.BikeCard.Models.ViewModels;
using Sam.Feature.BikeCard.Areas.BikeCard.Services;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace Sam.Feature.BikeCard.Areas.BikeCard.Controllers
{
    public class BikeCardContentController : Controller
    {
        private readonly IBikeCardService _bikeCardService;

        public BikeCardContentController(IBikeCardService bikeCardService)
        {
            _bikeCardService = bikeCardService; // new BikeCardService();
        }

        public ViewResult BikeCardIndex()
        {
            var viewModel = new BikeCardViewModel();

            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                var bikeCardContent = _bikeCardService.GetBikeCardContent(RenderingContext.Current.Rendering.DataSource);
                if (bikeCardContent != null)
                {
                    viewModel.Id = bikeCardContent.Id.ToString();
                    viewModel.Name = bikeCardContent.Name;
                    viewModel.TypeEngine = bikeCardContent.TypeEngine;
                    viewModel.MaxSpeed = bikeCardContent.MaxSpeed;
                    viewModel.Fuel = bikeCardContent.Fuel;
                    viewModel.Description = bikeCardContent.Description;
                    viewModel.Price = bikeCardContent.Price;
                }
            }

            return View("~/Areas/BikeCard/Views/BikeCardContent/BikeCardIndex.cshtml", viewModel);
        }
    }
}