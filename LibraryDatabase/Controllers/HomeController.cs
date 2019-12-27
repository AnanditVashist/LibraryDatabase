using LibraryDatabase.Infrastructure.Services;
using System.Web.Mvc;

namespace LibraryDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Book");
        }
    }
}