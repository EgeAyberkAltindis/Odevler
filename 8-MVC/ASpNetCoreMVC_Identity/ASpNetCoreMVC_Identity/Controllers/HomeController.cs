using ASpNetCoreMVC_Identity.Models;
using ASpNetCoreMVC_Identity.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASpNetCoreMVC_Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Shoe()
        {

            return View(AyakkabiData.Ayakkabi.ToList());
        }

        public IActionResult Update(int id)
        {
            Ayakkabi ayakkabi = AyakkabiData.Ayakkabi.FirstOrDefault(x => x.ID == id);//Nike
            return View(ayakkabi);
        }
        [HttpPost]
        public IActionResult Update(Ayakkabi ayakkabi)//Adidas
        {
            //
           var updated= AyakkabiData.Ayakkabi.FirstOrDefault(x => x.ID == ayakkabi.ID);
            updated.Marka = ayakkabi.Marka;
            updated.Model = ayakkabi.Model;
            updated.Fiyat = ayakkabi.Fiyat;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}