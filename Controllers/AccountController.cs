using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;

namespace SecondMVCApp.Controllers
{
    public class AccountController : Controller
    {

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Login(string userName, string password)
        //{

        //    if(userName == "Bright" && password == "Future")
        //    {
        //        return RedirectToAction("Dashboard");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }
        //    return View();
        //}


        [HttpGet]
        public IActionResult Login()
        {
            User user = new User();
            user.ClassName = "Test";
            return View(user);
        }


        // This is Comment
       [HttpPost]
        public IActionResult Login(User user)
        {
                
            if(user.UserName == "Test" && user.Password =="test")
            {
                return RedirectToAction(nameof(Dashboard)); 
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        public IActionResult Dashboard()
        {
            return View();
        }



        
    }
}
