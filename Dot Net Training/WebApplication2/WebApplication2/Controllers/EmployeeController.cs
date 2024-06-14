using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmpFirstName()
        {
            return View();
        }
        public IActionResult EmpLastName()
        {
            return View();
        }
    }
}
