using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "I am student.";
        }
        public string GetRollNumber()
        {
            return "1234";
        }
        public string GetName()
        {
            return "Dishari Roy";
        }
    }
}
