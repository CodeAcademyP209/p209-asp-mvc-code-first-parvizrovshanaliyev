using BookAndCarSTR.DAL;
using BookAndCarSTR.Models;
using BookAndCarSTR.ModelView;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookAndCarSTR.Controllers
{
    public class BookController : Controller
    {
        private readonly ContextDB _context;
        // GET: Books
        public BookController()
        {
            _context = new ContextDB();
        }
        public ActionResult Index()
        {
            //var BookAndCar = new BookAndCAr
            //{
            //    Books = _context.Books.ToList()

            //};
            return View(_context.Books);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Name, string Description, int Year, string Price, string Author, string Date)
        {
            var book = new Book();
            book.Name = Name;
            book.Author = Author;
            book.Description = Description;
            book.Create = Convert.ToDateTime(Date);
            book.Year = Year;
            book.Price = Convert.ToDecimal(Price);
            _context.Books.Add(book);
            _context.SaveChanges();

            //string s = "";
            //try
            //{
            //    _context.SaveChanges();

            //}
            //catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        s+= string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            s += string.Format("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    return Content(s);
            //}


            return RedirectToAction("Index");
        }
    }
}