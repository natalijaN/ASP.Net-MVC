using Academy.App.New.Domain.Models;
using Academy.New.App.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.App.New.DataAccess.Repositories.EntityRepositories
{
    public class StudentEntityRepository : IRepository<Student>
    {
        private AcademyDbContext _context;
        public StudentEntityRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (student != null) _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Student entity)
        {
            _context.Students.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Student entity)
        {
            Student student = _context.Students.FirstOrDefault(x => x.Id == entity.Id);
            if (student != null)
            {
                student.FirstName = entity.FirstName;
                student.LastName = entity.LastName;
                student.Age = entity.Age;
                student.Academy = entity.Academy;
                if (entity.Projects != null) student.Projects = entity.Projects;
                _context.Students.Update(student);
            }
        }
    }
}
