using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        public CCSDataAccsess dbcontext;
        private readonly ILogger<HomeController> _logger;
        CCSDataAccsess db = new CCSDataAccsess();
        public HomeController(ILogger<HomeController> logger, CCSDataAccsess context)
        {
            _logger = logger;
            dbcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {

            TestModel model = new TestModel();

            model.Ulkeler = new SelectList(dbcontext.Countries, "ID", "CountryName");
            model.Sehir = new SelectList(dbcontext.Cities, "Id", "CityName");
            model.Eyalet = new SelectList(dbcontext.States, "ID", "StateName");



            //var ulkeler = dbcontext.Countries.ToList();


            //var Donut = new TestModel();
            //Donut.Ulkeler = new SelectList(ulkeler, "ID", "CountryName");

            return View(model);

        }
        public IActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public JsonResult CityGet(int id)

        {

            var cities = dbcontext.Cities.Where(x => x.CountryID == id).ToList();

            //List<City> cities = dbcontext.Cities.Where(x => x.CountryID == p).ToList();
            return Json(cities);
        }

        public JsonResult StateGet(int id)

        {

            var states = dbcontext.States.Where(x => x.CityId == id).ToList();

      
            return Json(states);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public IActionResult CountryAdd(CCSDataAccsess cCSData)
        //{
        //    return (IActionResult)cCSData;
        //}
    }
}
