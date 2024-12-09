using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _DashboardHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
