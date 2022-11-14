using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;

namespace SecondMVCApp.Controllers
{
    public class DoctorController : Controller
    {

        public static List<Doctor> doctors = new List<Doctor>();




        public IActionResult Index()
        {

            //doctors.Add(new Doctor() { Id = 1, Name = "Sumit", Qualification = "MBBS" });
            //doctors.Add(new Doctor() { Id = 2, Name = "Sumit", Qualification = "MBBS" });
            //doctors.Add(new Doctor() { Id = 3, Name = "Sumit", Qualification = "MBBS" });
            //doctors.Add(new Doctor() { Id = 4, Name = "Sumit", Qualification = "MBBS" });


            return View(doctors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Doctor doctor = new Doctor();

            return View(doctor);
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            doctors.Add(doctor);

            return RedirectToAction("Index");

        }




        public IActionResult Delete(int id)
        {

            var doctor = doctors.FirstOrDefault(doctor => doctor.Id == id);

            doctors.Remove(doctor);

            return RedirectToAction("Index");
        }
    }
}
