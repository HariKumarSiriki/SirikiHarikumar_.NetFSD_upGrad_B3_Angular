using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

   
    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public IActionResult Students()
    {
        var students = _context.Students
                               .Include(s => s.Course)
                               .ToList();

        ViewBag.Courses = _context.Courses.ToList(); 

        return View(students);
    }

    [HttpPost]
    public IActionResult Students(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        return RedirectToAction("Students");
    }


    [HttpGet]
    public IActionResult Courses()
    {
        var courses = _context.Courses
                              .Include(c => c.Students)
                              .ToList();

        return View(courses);
    }

    [HttpPost]
    public IActionResult Courses(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();

        return RedirectToAction("Courses");
    }
}