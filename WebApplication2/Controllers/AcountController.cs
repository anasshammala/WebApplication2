using DataValidationProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AcountController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLogin model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("LoginSuccess");
        }

        // GET: /Account/LoginSuccess
        [HttpGet]
        public IActionResult LoginSuccess()
        {
            return View();
        }

    }
}
