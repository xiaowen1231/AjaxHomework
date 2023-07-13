using Microsoft.AspNetCore.Mvc;

namespace AjaxHomework.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult TouristAttractions()
        {
            return View();
        }
    }
}
