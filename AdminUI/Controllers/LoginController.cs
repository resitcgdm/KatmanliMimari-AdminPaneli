using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class LoginController : Controller
    {
        AdminContext c = new AdminContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GirisYap(User user)
        {
            var bilgi = c.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (bilgi != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
