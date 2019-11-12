using Glass.Mapper.Sc.Web.Mvc;
using Sam.Feature.MyButton.Areas.MyButton.Models.Rendering_Parameters;
using Sam.Feature.MyButton.Areas.MyButton.Models.ScModels;
using Sam.Feature.MyButton.Areas.MyButton.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.Feature.MyButton.Areas.MyButton.Controllers
{
    public class MyButtonController : GlassController
    {
        // GET: MyButton/MyButton

        public ViewResult MyButton()
        {
            var model = new ButtonViewModel(GetDataSourceItem<ButtonScModel>(), GetRenderingParameters<ButtonRP>());

            return View("~/Areas/MyButton/Views/MyButton/MyButton.cshtml", model);
        }
    }
}