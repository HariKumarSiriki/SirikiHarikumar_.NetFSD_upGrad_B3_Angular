using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(string name, int? age, string course)
        {
          
            if (string.IsNullOrWhiteSpace(name) || age == null || string.IsNullOrWhiteSpace(course))
            {
                ViewBag.Error = "All fields are required";
                return View();
            }

         
            return RedirectToAction("Display", new
            {
                name = name,
                age = age,
                course = course
            });
        }

       
        [HttpGet("display")]
        public IActionResult Display(string name, int age, string course)
        {
           
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Course = course;

            return View();
        }
    }
}