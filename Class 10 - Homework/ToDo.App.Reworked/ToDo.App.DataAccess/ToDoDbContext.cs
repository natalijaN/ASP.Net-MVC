using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions options)
               : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        protected override void OnModelCreating(
             ModelBuilder modelBuilder)
        {
            // CONFIGURATIONS
            modelBuilder.Entity<User>()
               .HasMany(x => x.ToDos)
               .WithOne(x => x.User)
               .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<ToDo>()
               .HasMany(x => x.SubTasks)
               .WithOne(x => x.ToDo)
               .HasForeignKey(x => x.ToDoID);
            modelBuilder.Entity<User>()
               .HasData(
               new User()
               {
                   Id = 1,
                   FirstName = "John",
                   LastName = "Doe",
                   AverageFreeTime = 5
               }
               );
            modelBuilder.Entity<ToDo>()
            .HasData(
            new ToDo()
            {
                Id = 1,
                Title = "Basketball Training",
                ImporanceOfTask = ImporanceOfTask.Medium,
                Status = Status.InProgress,
                TypeOfToDo = TypeOfTodo.Hobby,
                UserId = 1
            },
            new ToDo()
            {
                Id = 2,
                Title = "Project",
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.NotDone,
                TypeOfToDo = TypeOfTodo.Work,
                UserId = 1
            },
             new ToDo()
             {
                 Id = 3,
                 Title = "Reading Book",
                 ImporanceOfTask = ImporanceOfTask.Important,
                 Status = Status.Done,
                 TypeOfToDo = TypeOfTodo.Personal,
                 UserId = 1
             }
             );
            modelBuilder.Entity<SubTask>()
           .HasData(
           new SubTask()
           {
               Id = 1,
               Title = "Workout",
               Descrition = "Workout before Training",
               SubStatus = SubStatus.NotDone,
               ToDoID = 1
           },
             new SubTask()
             {
                 Id = 2,
                 Title = "Spa",
                 Descrition = "Spa after Training",
                 SubStatus = SubStatus.NotDone,
                 ToDoID = 1
             },
            new SubTask()
            {
                Id = 3,
                Title = "Analyze",
                Descrition = "Analyze Data",
                SubStatus = SubStatus.Done,
                ToDoID = 2
            },
            new SubTask()
            {
                Id = 4,
                Title = "Design",
                Descrition = "Design Engine",
                SubStatus = SubStatus.NotDone,
                ToDoID = 2
            },
            new SubTask()
            {
                Id = 5,
                Title = "Go to the library",
                Descrition = "Go to the library",
                SubStatus = SubStatus.Done,
                ToDoID = 3
            },
            new SubTask()
            {
                Id = 6,
                Title = "ReadTheBook",
                Descrition = "You need to start reading the book",
                SubStatus = SubStatus.NotDone,
                ToDoID = 3
            }
            );
        }
    }
}