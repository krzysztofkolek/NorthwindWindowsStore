using NorthwindWindowsStore.Service;
using System;
using System.Web.Mvc;

namespace NorthwindWindowsStoreService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var path = String.Format(@"{0}bin\App_Data", Server.MapPath("~"));
            var test = new EmployeeService(path).GetAll();
            return View();
        }
    }
}
