using BookAndCarSTR.DAL;
using BookAndCarSTR.Models;
using BookAndCarSTR.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookAndCarSTR.Controllers
{
    public class HomeController : Controller
    {
        //private List<Book> books;
        //private List<Car> cars;
        private readonly ContextDB _context;
        public HomeController()
        {
            _context = new ContextDB();
            //Book book1 = new Book
            //{
            //    Name = "cerpeleng ucuran",
            //    Description = "Xalid Hüseyninin bu debüt romanını artıq yeni əsrin baş romanı, müəllifini isə canlı klassik hesab eləyirlər.",
            //    Price = 15,
            //    Image = "1.jpg",
            //    Year = 2003,
            //    Author = "Xalid Huseyn",
            //    Create = DateTime.Now,
            //    Update = DateTime.Now
            //};
            //Book book2 = new Book
            //{
            //    Name = "Min Mohtesem Gunes",
            //    Description = "Roman Əfqanıstanı darmadağın edən müharibənin qurbanı olmuş iki əfqan qadınının həyatından bəhs edir",
            //    Price = 20,
            //    Image = "2.jpg",
            //    Year = 2007,
            //    Author = "Xalid Huseyn",
            //    Create = DateTime.Now,
            //    Update = DateTime.Now
            //};

            //Car car1 = new Car
            //{
            //    BrandName = "VolksWagen",
            //    ModelName = "Touareg",
            //    Description = "The Touareg “Atmosphere” is uncompromising in terms of its exquisite materials and exceptional comfort.",
            //    Create = DateTime.Now,
            //    Update = DateTime.Now,
            //    MileAge = 100,
            //    MotorType = "benzin",
            //    Image = "t.jpg",
            //};

            // books = new List<Book> { book1, book2 };
            // cars = new List<Car> { car1 };



        }
        public ActionResult Index()
        {

            //var BookAndCar = new BookAndCAr
            //{
            //    Books = _context.Books.ToList()
               
            //};

            return View(_context.Books);
        }

        public ActionResult About()
        {
            //var BookAndCar = new BookAndCAr
            //{
                
            //    Cars = _context.Cars.ToList()
            //};

            return View(_context.Cars);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}