using Aspnetcore.IdentityArea.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.IdentityArea.Areas.Dashboard.Controllers
{
    public class AccountContoller : Controller
    {
        private readonly UserManager<AppUser> _appUser;

        public AccountContoller(UserManager<AppUser> appUser)
        {
            _appUser = appUser;
        }
       
       

        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(AppUser appUser) 
        {
            return View();
        }
    }
}
