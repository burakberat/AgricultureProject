using AgricultureDataAccessLayer.Contexts;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext context = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            //ViewBag.currentMonthMessage = context.Contacts.Count(x => x.Date.Month.Days = DateTime.Today);

            ViewBag.announcemenetTrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcemenetFalse = context.Announcements.Where(x => x.Status == false).Count();

            ViewBag.genelMudur = context.Teams.Where(x => x.Title == "Genel Müdür").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.simav = context.Teams.Where(x => x.Title == "Simav Yöresel Lezzetler").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sekreter = context.Teams.Where(x => x.Title == "Sekreter").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.koruma = context.Teams.Where(x => x.Title == "Koruma").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
