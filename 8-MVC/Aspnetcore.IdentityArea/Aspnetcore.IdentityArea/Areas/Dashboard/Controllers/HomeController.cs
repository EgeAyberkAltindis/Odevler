using Aspnetcore.IdentityArea.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.IdentityArea.Areas.Dashboard.Controllers
{
    public class HomeController : Controller
    {
        [Area("Dashboard")]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
