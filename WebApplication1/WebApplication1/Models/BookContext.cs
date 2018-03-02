using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet <Rent> Rents { get; set; }
    }
}