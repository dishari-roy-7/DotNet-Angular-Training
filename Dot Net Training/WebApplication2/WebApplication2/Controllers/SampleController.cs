using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Hello World!";
        }
        public string FirstName()
        {
            return "Dishari";
        }
        public string LastName()
        {
            return "Roy";
        }
    }
}
