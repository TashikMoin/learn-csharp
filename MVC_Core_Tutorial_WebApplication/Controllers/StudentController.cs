using Microsoft.AspNetCore.Mvc;
using MVC_Core_WebApplication.Models;

namespace MVC_Core_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _Students;

        public StudentController(IStudentRepository Students)
        {
            _Students = Students;
        }

        public string Index()
        {
            return _Students.GetStudent(3).Id.ToString();
        }

        public ViewResult Details()
        {
            Student Model = _Students.GetStudent(3);
            return View(Model);
        }
    }
}
