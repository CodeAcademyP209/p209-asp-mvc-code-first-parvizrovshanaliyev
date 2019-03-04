using BookAndCarSTR.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookAndCarSTR.DAL
{
    public class ContextDB:DbContext
    {
        public ContextDB():base("Book_Car")
        {

        }

        public DbSet <Book> Books { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}