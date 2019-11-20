using Sam.Feature.TripCard.Areas.TripCard.Models.ViewModels;
using Sam.Feature.TripCard.Areas.TripCard.Services;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.Feature.TripCard.Areas.TripCard.Controllers
{
    public class TripCardContentController : Controller
    {
        private readonly ITripCardService _tripCardService;

        public TripCardContentController(ITripCardService tripCardService)
        {
            _tripCardService = tripCardService; // new BikeCardService();
        }

        public ViewResult TripCardIndex()
        {
            var viewModel = new TripCardViewModel();

            if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                var tripCardContent = _tripCardService.GetTripCardContent(RenderingContext.Current.Rendering.DataSource);
                if (tripCardContent != null)
                {
                    viewModel.Id = tripCardContent.Id;
                    viewModel.ImageUrl = tripCardContent.Image.Src;
                    viewModel.Title = tripCardContent.Title;
                    viewModel.Description = tripCardContent.Description;
                    viewModel.StartDate = tripCardContent.StartDate;
                    viewModel.EndDate = tripCardContent.EndDate;
                    viewModel.Price = tripCardContent.Price;
                }
            }

            return View("~/Areas/TripCard/Views/TripCardContent/TripCardIndex.cshtml", viewModel);
        }
    }
}