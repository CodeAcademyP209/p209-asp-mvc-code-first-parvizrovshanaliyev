namespace BookAndCarSTR.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookAndCarSTR.DAL.ContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookAndCarSTR.DAL.ContextDB context)
        {
            context.Books.AddOrUpdate(x => x.Id,
                new Models.Book() { Id = 5, Name = "Cerpeleng Ucuran",Description= "Xalid Hüseyninin bu debüt romanını artıq yeni əsrin baş romanı, müəllifini isə canlı klassik hesab eləyirlər.",Price=15,Image="1.jpg",Author= "Xalid Huseyn",Year=2003,Create=DateTime.Now },
                new Models.Book() { Id = 8, Name = "Min Mohtesem Gunes", Description= "Roman Əfqanıstanı darmadağın edən müharibənin qurbanı olmuş iki əfqan qadınının həyatından bəhs edir", Price=20,Image="2.jpg",Author= "Xalid Huseyn",Year=2007, Create=DateTime.Now }

                );
            context.Cars.AddOrUpdate(x => x.Id,
                new Models.Car()
                {
                    Id = 1,
                    BrandName = "VolksWagen",
                    ModelName = "Touareg",
                    Description = "The Touareg “Atmosphere” is uncompromising in terms of its exquisite materials and exceptional comfort.",
                    Create = DateTime.Now,
                    MileAge = 100,
                    MotorType = "benzin",
                    Image = "t.jpg",
                }


                );
        }
    }
}
