﻿// <auto-generated />
using Academy.App.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academy.App.DataAccess.Migrations
{
    [DbContext(typeof(AcademyDbContext))]
    [Migration("20190706084625_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy.App.Domain.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstimatedTime");

                    b.Property<int>("StudentId");

                    b.Property<int>("TimeSpent");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Projects");

                    b.HasData(
                        new { Id = 1, EstimatedTime = 20, StudentId = 1, TimeSpent = 25, Title = "ToDo App" },
                        new { Id = 2, EstimatedTime = 30, StudentId = 2, TimeSpent = 45, Title = "Pizza App" },
                        new { Id = 3, EstimatedTime = 20, StudentId = 3, TimeSpent = 15, Title = "Calculator App" },
                        new { Id = 4, EstimatedTime = 80, StudentId = 2, TimeSpent = 100, Title = "Bank App" },
                        new { Id = 5, EstimatedTime = 70, StudentId = 1, TimeSpent = 68, Title = "Market App" }
                    );
                });

            modelBuilder.Entity("Academy.App.Domain.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Academy");

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new { Id = 1, Academy = 1, Age = 26, FirstName = "John", LastName = "Doe" },
                        new { Id = 2, Academy = 2, Age = 23, FirstName = "Jane", LastName = "Doe" },
                        new { Id = 3, Academy = 3, Age = 29, FirstName = "Mark", LastName = "Brown" }
                    );
                });

            modelBuilder.Entity("Academy.App.Domain.Models.Project", b =>
                {
                    b.HasOne("Academy.App.Domain.Models.Student", "Student")
                        .WithMany("Projects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
