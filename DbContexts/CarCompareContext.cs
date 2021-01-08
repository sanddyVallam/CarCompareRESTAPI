using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCampareToolRESTAPI.Model;
using Microsoft.Azure.DevOps.Licensing.WebApi;
using Microsoft.EntityFrameworkCore;

namespace CarCampareToolRESTAPI.DbContexts
{
    public class CarCompareContext : DbContext
    {
        public CarCompareContext(DbContextOptions<CarCompareContext> options) : base(options) { }

        public DbSet<CarModelCommon> CarModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CarModelCommon>().HasNoKey();

            modelBuilder.Entity<CarModelCommon>().HasData(new CarModelCommon()
            {
                id = 1,
                Make = "Honda",
                Color = "Green",
                Model = "CRV ",
                HwMPG = 33,
                Price = 23845,
                TCCRating = 8,
                Year = 2016
            },
            new CarModelCommon()
            {
                id = 2,
                Make = "Ford ",
                Color = "Red",
                Model = "Escape ",
                HwMPG = 32,
                Price = 23590,
                TCCRating = 7.8,
                Year = 2017
            },
            new CarModelCommon()
            {
                id= 3,
                Make = "Hyundai ",
                Color = "Grey",
                Model = "Sante Fe",
                HwMPG = 27,
                Price = 24950,
                TCCRating = 8,
                Year = 2016
            },
            new CarModelCommon()
            {
                id = 4,
                Make = "Mazda ",
                Color = "Red",
                Model = "CX-5",
                HwMPG = 35,
                Price = 21795,
                TCCRating = 8,
                Year = 2017
            },
            new CarModelCommon()
            {
                id = 5,
                Make = "Subaru ",
                Color = "Blue",
                Model = "Forester",
                HwMPG = 32,
                Price = 22395,
                TCCRating = 8.4,
                Year = 2016
            });

            //modelBuilder.Entity<CarModelCommon>().HasNoKey();


            base.OnModelCreating(modelBuilder);
        }
    }
}
