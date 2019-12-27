using LibraryDatabase.Infrastructure.Services;
using LibraryDatabase.Infrastructure.Utils;
using System;
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
            //TODO


            var id = Convert.ToInt32(bookId);
            var book = BookDataService.GetBookById(id);
            return View(book);
        }
    }
}