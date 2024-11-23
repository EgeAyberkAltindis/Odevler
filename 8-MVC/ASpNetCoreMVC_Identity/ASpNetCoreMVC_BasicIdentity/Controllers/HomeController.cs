using ASpNetCoreMVC_BasicIdentity.Models;
using ASpNetCoreMVC_BasicIdentity.Models.Context;
using ASpNetCoreMVC_BasicIdentity.Models.Entities;
using ASpNetCoreMVC_BasicIdentity.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASpNetCoreMVC_BasicIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, ProjectContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Register
        public IActionResult Register()
        {
            return View();
        }

        //Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM,bool rememberMe)
        {
            if (ModelState.IsValid)
            {

                AppUser appUser =await _userManager.FindByEmailAsync(loginVM.Email);

                if (appUser != null)
                {
                  var result= await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, rememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }

                
            }
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM user)
        {

            if (ModelState.IsValid)
            {

                AppUser appUser = new AppUser
                {
                    UserName = user.Username,
                    Email = user.Email
                };

                //veritabanı kayıt işlemi
                var result = await _userManager.CreateAsync(appUser, user.ConfirmPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return View(user);
                }


            }
            else
            {
                return View(user);
            }


        }


        //Login (Post)

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}