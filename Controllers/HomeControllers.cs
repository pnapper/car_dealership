using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/cars")]
        public ActionResult Cars()
        {
          List<Car> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpPost("/cars/user")]
        public ActionResult CarsUser()
        {
          Car.ClearAll();
          return View();
        }

        [HttpPost("/cars/create")]
        public ActionResult CarsCreate()
        {
          Car newCar = new Car (Request.Form["new-car"],
            int.Parse(Request.Form["new-car-price"]),
            int.Parse(Request.Form["new-mileage"])
          );
          newCar.Save();
          return View(newCar);
        }
    }
}
