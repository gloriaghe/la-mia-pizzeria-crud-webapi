using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class GuestController : Controller
    {


        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            return View();
        }
        public IActionResult Detail(int id)
        {
            ViewData["title"] = "Dettaglio Pizza";

            return View(id);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

    }
}