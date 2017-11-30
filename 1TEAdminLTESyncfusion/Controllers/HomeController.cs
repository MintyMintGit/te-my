using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _1TE_MY.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace _1TE_MY.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Culture(String Culture)
        {
            ResourceHelper.SetUserLocale(Culture);
            Response.Cookies.Append(
       CookieRequestCultureProvider.DefaultCookieName,
       CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(Culture)),
       new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
   );

            return  RedirectToAction("Login","Account");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
