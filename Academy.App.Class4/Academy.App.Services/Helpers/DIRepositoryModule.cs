using Academy.App.DataAccess;
using Academy.App.DataAccess.Repositories;
using Academy.App.DataAccess.Repositories.EntityRepositories;
using Academy.App.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.App.Services.Helpers
{
    public static class DIRepositoryModule 
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddDbContext<AcademyDbContext>(x =>
            x.UseSqlServer("Server=.\\SQLExpress;Database=AcademyAppDb;Trusted_Connection=True")
            );
            services.AddTransient<IRepository<Student>, StudentEntityRepository>();
            services.AddTransient<IRepository<Project>, ProjectEntityRepository>();
            return services;
        }
    }
}
