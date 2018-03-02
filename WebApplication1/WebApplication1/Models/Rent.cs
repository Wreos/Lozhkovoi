using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int CarId { get; set; }
        public DateTime Date { get; set; }
    }
}