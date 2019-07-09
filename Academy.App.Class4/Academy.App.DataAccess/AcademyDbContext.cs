using Academy.App.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.App.Domain.Enums;

namespace Academy.App.DataAccess
{
    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext(DbContextOptions options)
           : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Projects)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.StudentId);
            modelBuilder.Entity<Student>()
                .HasData(
                 new Student()
                 {
                     Id = 1,
                     FirstName = "John",
                     LastName = "Doe",
                     Age = 26,
                     Academy = StudentAcademy.Code
                 },
                 new Student()
                 {
                     Id = 2,
                     FirstName = "Jane",
                     LastName = "Doe",
                     Age = 23,
                     Academy = StudentAcademy.Design
                 },
                 new Student()
                 {
                     Id = 3,
                     FirstName = "Mark",
                     LastName = "Brown",
                     Age = 29,
                     Academy = StudentAcademy.Network,
                 });
            modelBuilder.Entity<Project>()
                .HasData(
                new Project()
                {
                    Id = 1,
                    Title = "ToDo App",
                    EstimatedTime = 20,
                    TimeSpent = 25,
                    StudentId = 1
                },
                new Project()
                {
                    Id = 2,
                    Title = "Pizza App",
                    EstimatedTime = 30,
                    TimeSpent = 45,
                    StudentId = 2
                },
                 new Project()
                 {
                     Id = 3,
                     Title = "Calculator App",
                     EstimatedTime = 20,
                     TimeSpent = 15,
                     StudentId = 3
                 },
                 new Project()
                 {
                     Id = 4,
                     Title = "Bank App",
                     EstimatedTime = 80,
                     TimeSpent = 100,
                     StudentId = 2
                 },
                 new Project()
                 {
                     Id = 5,
                     Title = "Market App",
                     EstimatedTime = 70,
                     TimeSpent = 68,
                     StudentId = 1
                 });
        }
    }
}
