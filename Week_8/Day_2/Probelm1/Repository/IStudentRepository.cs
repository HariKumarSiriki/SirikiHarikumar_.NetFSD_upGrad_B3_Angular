using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public interface IStudentRepository
    {
         IEnumerable<Student> GetStudentsWithCourse();
      IEnumerable<Course> GetCoursesWithStudents();
    }
}
