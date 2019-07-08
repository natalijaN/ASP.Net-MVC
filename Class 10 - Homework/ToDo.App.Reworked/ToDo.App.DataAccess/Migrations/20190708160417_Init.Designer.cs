﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoApp.DataAccess;

namespace ToDoApp.DataAccess.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20190708160417_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoApp.Domain.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrition");

                    b.Property<int>("SubStatus");

                    b.Property<string>("Title");

                    b.Property<int>("ToDoID");

                    b.HasKey("Id");

                    b.HasIndex("ToDoID");

                    b.ToTable("SubTasks");

                    b.HasData(
                        new { Id = 1, Descrition = "Workout before Training", SubStatus = 1, Title = "Workout", ToDoID = 1 },
                        new { Id = 2, Descrition = "Spa after Training", SubStatus = 1, Title = "Spa", ToDoID = 1 },
                        new { Id = 3, Descrition = "Analyze Data", SubStatus = 0, Title = "Analyze", ToDoID = 2 },
                        new { Id = 4, Descrition = "Design Engine", SubStatus = 1, Title = "Design", ToDoID = 2 },
                        new { Id = 5, Descrition = "Go to the library", SubStatus = 0, Title = "Go to the library", ToDoID = 3 },
                        new { Id = 6, Descrition = "You need to start reading the book", SubStatus = 1, Title = "ReadTheBook", ToDoID = 3 }
                    );
                });

            modelBuilder.Entity("ToDoApp.Domain.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrition");

                    b.Property<int>("ImporanceOfTask");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("TypeOfToDo");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ToDos");

                    b.HasData(
                        new { Id = 1, ImporanceOfTask = 2, Status = 2, Title = "Basketball Training", TypeOfToDo = 3, UserId = 1 },
                        new { Id = 2, ImporanceOfTask = 1, Status = 1, Title = "Project", TypeOfToDo = 1, UserId = 1 },
                        new { Id = 3, ImporanceOfTask = 1, Status = 3, Title = "Reading Book", TypeOfToDo = 2, UserId = 1 }
                    );
                });

            modelBuilder.Entity("ToDoApp.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageFreeTime");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, AverageFreeTime = 5m, FirstName = "John", LastName = "Doe" }
                    );
                });

            modelBuilder.Entity("ToDoApp.Domain.SubTask", b =>
                {
                    b.HasOne("ToDoApp.Domain.ToDo", "ToDo")
                        .WithMany("SubTasks")
                        .HasForeignKey("ToDoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDoApp.Domain.ToDo", b =>
                {
                    b.HasOne("ToDoApp.Domain.User", "User")
                        .WithMany("ToDos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}