using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;

namespace SecondMVCApp.Controllers
{
    public class UserController : Controller
    {

        public static List<User> Users;

        static UserController()
        {
            Users = new List<User>();
        }


        public IActionResult Index()
        {
            return View(Users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {

            Users.Add(user);

            return RedirectToAction("Index");

        }



        public IActionResult Delete(int id)
        {

            var user = Users.FirstOrDefault(user=>user.Id == id);


            Users.Remove(user);


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            User user = Users.FirstOrDefault(user => user.Id == id);

            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {

            //User userToUpdte1 = new User();
            //foreach (var u in Users)
            //{
            //    if (u.Id == user.Id)
            //    {
            //        userToUpdte1 = u;
            //    }
            //}


            User userToUpdate = Users.FirstOrDefault(u => u.Id == user.Id);

            userToUpdate.UserName= user.UserName;
            userToUpdate.Password= user.Password;
            userToUpdate.ClassName= user.ClassName;

            return RedirectToAction("Index");
        }





    }
}
