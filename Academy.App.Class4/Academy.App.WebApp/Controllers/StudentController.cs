using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.App.New.Domain.Models;
using Academy.App.New.Services.Services;
using Academy.App.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academy.App.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private IProjectService _projectService;
        public StudentController(IStudentService studentService, IProjectService projectService)
        {
            _studentService = studentService;
            _projectService = projectService;
        }
        public IActionResult AllStudents()
        {
            List<Project> projects = _projectService.GetAllProjects();
            List<ProjectViewModel> projectModel = new List<ProjectViewModel>();

            foreach (var project in projects)
            {
                projectModel.Add(new ProjectViewModel()
                {
                    Title = project.Title,
                    EstimatedTime = project.EstimatedTime,
                    TimeSpent = project.TimeSpent
                });
            }

            List<Student> students = _studentService.GetAllStudents();
            List<StudentViewModel> studentModel = new List<StudentViewModel>();

            foreach (var student in students)
            {
                studentModel.Add(new StudentViewModel()
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Age = student.Age,
                    Academy = student.Academy,
                    Projects = projectModel
                });
            }
            ShowAllStudents showAll = new ShowAllStudents()
            {
                Students = studentModel
            };
            return View(showAll);
        }
        [HttpGet("AddStudent")]
        public IActionResult AddStudent()
        {
            return View(new AddStudent());
        }
        [HttpPost("AddStudent")]
        public IActionResult AddStudent(AddStudent model)
        {
            Student student = new Student()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Academy = model.Academy
            };

            _studentService.AddNewStudent(student);
            return View("_ThankYou");
        }
    }
}