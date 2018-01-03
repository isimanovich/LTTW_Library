using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using LTTW_Library.Models;

namespace LTTW_Library.Controllers
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

        // GET: Books
        public ActionResult Index()
        {
            var books = _context.Books.Include(b => b.Genre).ToList();
            return View(books);
        }

        // GET: Details
        public ActionResult Details(string id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

    }
}