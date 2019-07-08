using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess.Repositories.CacheRepositories;
using ToDoApp.Domain;

namespace ToDoApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddDbContext<DataAccess.ToDoDbContext>(x =>
            x.UseSqlServer("Server=.\\SQLExpress;Database=ToDoDbEntity;Trusted_Connection=True")
            );
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<ToDo>, ToDoRepository>();
            services.AddTransient<IRepository<SubTask>, SubTaskRepository>();
            return services;
        }
    }
}
