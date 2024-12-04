using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _MapPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new AgricultureContext();
            var values = context.Addresses.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
