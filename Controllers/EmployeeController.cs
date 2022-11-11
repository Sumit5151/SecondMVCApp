using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecondMVCApp.Models;

namespace SecondMVCApp.Controllers
{
    public class EmployeeController : Controller
    {

        public static List<Employee> employees = new List<Employee>();

        [HttpGet]
        public IActionResult Create()
        {
            Employee employee = new Employee();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }

        

        public IActionResult Index()
        {
            return View(employees);
        }

        
    }
}
