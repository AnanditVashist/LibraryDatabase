using LibraryDatabase.Infrastructure.Services;
using LibraryDatabase.Infrastructure.Utils;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Web.Mvc;

namespace LibraryDatabase.Controllers
{
    public class BookController : Controller
    {
        //public ActionResult Example()
        //{
        //    //Get All Veriables
        //    //Do Error Checking
        //    //Process the result
        //}

        public ActionResult Index()
        {
            ViewBag.Books = BookDataService.GetAllBooks();

            //If method was not static - I would need to instansiate an object
            //var service = new BookDataService();
            //ViewBag.Books = service.GetAllBooks();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetBook()
        {
            var bookId = Request["selectedBook"];

            //Check if book Id is valid
            if(!ValidationUtil.IsInt(bookId))
            {
                return HttpNotFound();
            }

            //Check if book exists
            if (!BookDataService.Exists(bookId))
            {
                return HttpNotFound();
            }

            var book = BookDataService.GetBookById(Convert.ToInt32(bookId));
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RunSelenium()
        {

            var driver = new ChromeDriver("C:/Users/User1/Desktop")

            {
                Url = ("http://127.0.0.1:5500/views/checklist.html")

            };
            Thread.Sleep(2000);
            var submitButton = driver.FindElementByXPath("//*[@id='body']/div[1]/a[2]/input");
            submitButton.Click();
            Console.ReadLine();
            driver.Dispose();

            return View();
        }
    }
}