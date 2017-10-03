using _15CTHC12LTWeb.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _15CTHC12LTWeb.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;

        //Constructor
        public BookController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                BookId = 1,
                Title = "Tony Buoi sang",
                Author = "Tony",
                Cover = "/Content/images/book-1.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 2,
                Title = "Dac Nhan Tam",
                Author = "DC",
                Cover = "/Content/images/book-2.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 3,
                Title = "Pro ASP .NET MVC5",
                Author = "Freeman, Adam",
                Cover = "/Content/images/book-3.png"
            });
        }
        // GET: Book, Use View
        public ActionResult ListBook()
        {
            //Access DB to get List Book
            return View("ListBook", listBooks);
        }

        // Get: Edit Book
        [HttpGet]
        public ActionResult EditBook(int id)
        {
            Book editBook = listBooks.Find(s => s.BookId == id);

            return View(editBook);
        }
        //Post Edit Book
        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                Book editBook = listBooks.Find(s => s.BookId == book.BookId);
                editBook.Title = book.Title;
                editBook.Author = book.Author;
                editBook.Cover = book.Cover;

                return View("ListBook", listBooks);
            }
            else
            {
                ModelState.AddModelError("", "Gia tri nhap khong hop le!");
                return View();
            }
        }

        //No View
        public string HelloFirstMessage(string university)
        {
            return "Nguyen Van Teo" + ", University = " + university;
        }
    }
}