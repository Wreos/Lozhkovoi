using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarDbInitializer:DropCreateDatabaseAlways<BookContext>

    {
        protected override void Seed (BookContext db)
        {
            db.Cars.Add(new Car { Model = "Rio", Manufacter = "Kia", Price = 2625689, Probeg = 64000 });
            db.Cars.Add(new Car { Model = "Camry", Manufacter = "Toyota", Price = 1625689, Probeg = 32000 });
            db.Cars.Add(new Car { Model = "4х4", Manufacter = "Niva", Price = 900000, Probeg = 128000 });
            base.Seed(db);
        }
    }
}