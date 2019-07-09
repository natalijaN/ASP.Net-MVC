using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.App.New.DataAccess.Repositories;
using Academy.App.New.Domain.Models;

namespace Academy.App.New.Services.Services
{
    public class ProjectService : IProjectService
    {
        private IRepository<Project> _projectRepository;
        public ProjectService(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public int AddNewProject(Project entity)
        {
            return _projectRepository.Insert(entity);
        }

        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAll();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetById(id);
        }
    }
}
