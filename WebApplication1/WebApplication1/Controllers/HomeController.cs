using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Car> cars = db.Cars;
            ViewBag.Cars = cars;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.CarId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Rent rent)
        {
            rent.Date = DateTime.Now;
            db.Rents.Add(rent);
            db.SaveChanges();
            return "Спасибо , " + rent.Person + ", за покупку!";
        }
    }
}