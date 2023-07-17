using AjaxHomework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxHomework.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Address()
        {
            return View();
        }
        public IActionResult AddressCallback()
        {
            return View();
        }

        public IActionResult previewImage()
        {
            return View();
        }
        public IActionResult AddressFetch()
        {
            return View();
        }
        public IActionResult AutoComplete()
        {
            return View();
        }
    }
}