using Academy.App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.App.Services.Services
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
        int AddNewProject(Project entity);
    }
}
