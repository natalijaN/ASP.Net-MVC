using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.App.DataAccess.Repositories;
using Academy.App.Domain.Models;

namespace Academy.App.Services.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<Student> _studentRepository;
        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public int AddNewStudent(Student entity)
        {
            return _studentRepository.Insert(entity);
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
