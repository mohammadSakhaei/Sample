using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Note : you can bind same list from database  
        List<City> objList = new List<City>()
        {

            new City {Id=1,Name="Latur" },
            new City {Id=2,Name="Mumbai" },
            new City {Id=3,Name="Pune" },
            new City {Id=4,Name="Delhi" },
            new City {Id=5,Name="Dehradun" },
            new City {Id=6,Name="Noida" },
            new City {Id=7,Name="New Delhi" }

        };

        [HttpPost]
        public JsonResult Index(string prefix)
        {
            

            //Searching records from list using LINQ query  
            var cityName = objList.Where(o => o.Name.Contains(prefix)).Select(o => o.Name);

            //return Json(CityName, JsonRequestBehavior.AllowGet);
            return Json(cityName);
        }

    }
}
