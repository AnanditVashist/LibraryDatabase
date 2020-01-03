using LibraryDatabase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDatabase.Infrastructure.Services
{
    public class BookDataService
    {
        public static Book GetBookById(int id)
        {
            var books = GetAllBooks();
            //LINQ for finding book by id
            //return books.FirstOrDefault(b => b.Id == id);

            foreach(var book in books)
            {
                if(book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }

        public static List<Book> GetAllBooks()
        {
            string jsonPath = HttpContext.Current.Server.MapPath("~/App_Data/books.json");
            string bookJson = System.IO.File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<Book>>(bookJson);
        }

        public static bool Exists(string bookId)
        {
            var books = GetAllBooks();


            foreach (var book in books)
            {
                if (book.Id == Convert.ToInt32(bookId))
                {
                    return true;
                }


            }
            return false;
        }
    }
}