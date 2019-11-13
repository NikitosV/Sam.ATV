using Sam.Feature.BikeCard.Services;
using Sam.Feature.BikeCard.ViewModels.VM;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.Feature.BikeCard.Controllers
{
    public class BikeCardContentController : Controller
    {
        private readonly IBikeCardService _bikeCardService;

        public BikeCardContentController()
        {
            _bikeCardService = new BikeCardService();
        }

        public ViewResult BikeCardIndex()
        {
            var viewModel = new BikeCardViewModel();

            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                var bikeCardContent = _bikeCardService.GetBikeCardContent(RenderingContext.Current.Rendering.DataSource);
                if (bikeCardContent != null)
                {
                    viewModel.Id = bikeCardContent.Id;
                    viewModel.Name = bikeCardContent.Name;
                    viewModel.TypeEngine = bikeCardContent.TypeEngine;
                    viewModel.MaxSpeed = bikeCardContent.MaxSpeed;
                    viewModel.Fuel = bikeCardContent.Fuel;
                    viewModel.Description = bikeCardContent.Description;
                    viewModel.Price = bikeCardContent.Price;
                }
            }
            return View(viewModel);
        }
    }
}