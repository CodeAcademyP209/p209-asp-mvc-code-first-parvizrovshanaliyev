using BookAndCarSTR.DAL;
using BookAndCarSTR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAndCarSTR.ModelView
{
    public class BookAndCAr
    {
        public List<Book> Books { get; set; }
        public List<Car> Cars { get; set; }
    }
}