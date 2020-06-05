using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitapKurdu.Models;
using KitapKurdu.ViewModels;

namespace KitapKurdu.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageBooks))
                return View("List");
            else
                return View("ReadOnlyList");
        }


        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }
        [Authorize(Roles =RoleName.CanManageBooks)]
        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new BookFormViewModel
            {
                Genres = genres
            };

            return View("BookForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(c => c.Id == id);
            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel(book)
            {
                Genres = _context.Genres.ToList()
            };

            return View("BookForm", viewModel);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                book.DateAdded = DateTime.Now;
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(m => m.Id == book.Id);
                bookInDb.Name = book.Name;
                bookInDb.GenreId = book.GenreId;
                bookInDb.NumberInStock = book.NumberInStock;
                bookInDb.ReleaseDate = book.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }
    }
}
