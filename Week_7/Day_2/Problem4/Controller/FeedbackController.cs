using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        
        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("form")]
        public IActionResult Form(string name, string comments, int? rating)
        {
      
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(comments) ||
                rating == null)
            {
                ViewData["Error"] = "All fields are required";
                return View();
            }

            if (rating < 1 || rating > 5)
            {
                ViewData["Error"] = "Rating must be between 1 and 5";
                return View();
            }

            if (rating >= 4)
            {
                ViewData["Message"] = "Thank You!";
            }
            else
            {
                ViewData["Message"] = "We will improve!";
            }

            return View();
        }
    }
}