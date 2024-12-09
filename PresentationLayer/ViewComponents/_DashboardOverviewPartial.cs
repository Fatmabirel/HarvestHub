using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.surdurulebilirTarimUzmani = c.Teams.Where(x => x.Title == "Sürdürülebilir Tarım Uzmanı").Select(y => y.Name).FirstOrDefault();
            ViewBag.tarimDanismani = c.Teams.Where(x => x.Title == "Tarım Danışmanı").Select(y => y.Name).FirstOrDefault();
            ViewBag.ziraatMuhendisi = c.Teams.Where(x => x.Title == "Ziraat Mühendisi").Select(y => y.Name).FirstOrDefault();
            ViewBag.kaliteKontrolUzmanı = c.Teams.Where(x => x.Title == "Kalite Kontrol Uzmanı").Select(y => y.Name).FirstOrDefault();
            return View();
        }
    }
}
