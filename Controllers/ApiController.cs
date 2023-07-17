using AjaxHomework.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxHomework.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;

        public ApiController(DemoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Cities()
        {
            var cities = _context.Address.Select(c=>c.City).Distinct();
            return Json(cities);
        }

        public IActionResult Districts(string city)
        {
            var districts = _context.Address
                .Where(a=>a.SiteId.Contains(city))
                .Select(a=>a.SiteId.Substring(3,3))
                .Distinct();
            return Json(districts);
        }

        public IActionResult Road(string district)
        {
            var road = _context.Address
                .Where(a => a.SiteId == district)
                .Select(a => a.Road);
                
            return Json(road);
        }

        public bool CheckAccount(string account)
        {
            var accountInDb = _context.Members.Where(m=>m.Name == account).FirstOrDefault();
            bool hasAccount = accountInDb != null ? true : false;

            return hasAccount;
        }
        public IActionResult MembersName()
        {
            var membersName = _context.Members.Select(m=>m.Name);
            return Json(membersName);
        }
    }
}
