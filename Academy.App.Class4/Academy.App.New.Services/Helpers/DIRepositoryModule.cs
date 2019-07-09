using Academy.App.New.DataAccess.Repositories;
using Academy.App.New.DataAccess.Repositories.EntityRepositories;
using Academy.App.New.Domain.Models;
using Academy.New.App.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.App.New.Services.Helpers
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
