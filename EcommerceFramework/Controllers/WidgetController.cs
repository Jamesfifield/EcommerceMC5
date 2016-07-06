using System.Collections.Generic;
using System.Web.Mvc;
using EcommerceFramework.ViewModels.Widgets;

namespace EcommerceFramework.Controllers
{
    public class WidgetController : Controller
    {
        public ActionResult Card()
        {
            var viewModel = new List<WidgetCard>
            {
                new WidgetCard { Title = "Computer", ImageUri = "https://placehold.it/250x150" },
                new WidgetCard { Title = "Computer", ImageUri = "https://placehold.it/250x150" },
                new WidgetCard { Title = "Computer", ImageUri = "https://placehold.it/250x150" },
            };
            return PartialView("Widgets/_Card", viewModel);
        }
    }
}