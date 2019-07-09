using Academy.App.New.Domain.Models;
using Academy.New.App.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.App.New.DataAccess.Repositories.EntityRepositories
{
    public class ProjectEntityRepository : IRepository<Project>
    {
        private AcademyDbContext _context;
        public ProjectEntityRepository(AcademyDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Project project = _context.Projects.FirstOrDefault(x => x.Id == id);
            if (project != null) _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public Project GetById(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Project entity)
        {
            _context.Projects.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Project entity)
        {
            Project project = _context.Projects.FirstOrDefault(x => x.Id == entity.Id);
            if (project != null)
            {
                project.Title = entity.Title;
                project.EstimatedTime = entity.EstimatedTime;
                project.TimeSpent = entity.TimeSpent;
                _context.Projects.Update(project);
            }
        }
    }
}
