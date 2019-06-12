using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;
using ToDoApp.Models.ViewModels;
using ToDoApp.Models.Enums;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {

        private User _John { get; set; }

        public TaskController()
        {

            User john = new User()
            {
                FirstName = "John",
                LastName = "Doe",
                AverageFreeTime = 5

            };   

            ToDo basketball = new ToDo()
            {
                Title = "Basketball Training",
                ImporanceOfTask = ImportanceOfTask.Medium,
                Status = Status.InProgress,
                Type = TypeOfToDo.Hobby,
            };

            SubTask workout = new SubTask()
            {
                Title = "Workout",
                Descrition = "Workout before Training",
                SubStatus = SubStatus.NotDone
            };

            SubTask spa = new SubTask()
            {
                Title = "Spa",
                Descrition = "Spa after Training",
                SubStatus = SubStatus.NotDone
            };

            basketball.SubTasks.Add(workout);
            basketball.SubTasks.Add(spa);

            ToDo project = new ToDo()
            {
                Title = "Project",
                ImporanceOfTask = ImportanceOfTask.Important,
                Status = Status.NotDone,
                Type = TypeOfToDo.Work,
            };

            SubTask analyze = new SubTask()
            {
                Title = "Analyze",
                Descrition = "Analyze Data",
                SubStatus = SubStatus.Done
            };

            SubTask design = new SubTask()
            {
                Title = "Design",
                Descrition = "Design Engine",
                SubStatus = SubStatus.NotDone
            };

            project.SubTasks.Add(analyze);
            project.SubTasks.Add(design);


            ToDo readABook = new ToDo()
            {
                Title = "Reading Book",
                ImporanceOfTask =ImportanceOfTask.Important,
                Status = Status.Done,
                Type = TypeOfToDo.Personal,
            };

            SubTask  goToLibrary= new SubTask()
            {
                Title = "Go to the library",
                Descrition = "Go to the library",
                SubStatus = SubStatus.Done
            };

            SubTask readTheBook = new SubTask()
            {
                Title = "ReadTheBook",
                SubStatus = SubStatus.NotDone
            };

            readABook.SubTasks.Add(goToLibrary);
            readABook.SubTasks.Add(readTheBook);

            john.ToDos.Add(basketball);
            john.ToDos.Add(project);
            john.ToDos.Add(readABook);

            _John = john;
        }

        public IActionResult NotDoneTasks()
        {
            var notDoneTasks = _John.ToDos.Where(t => t.Status == Status.NotDone).ToList();

            NotDone notDone = new NotDone()
            {
                NotDoneTodos = notDoneTasks
            };
            return View(notDone);
        }

        public IActionResult InProgressTasks()
        {
            var inProgressTasks = _John.ToDos.Where(t => t.Status == Status.InProgress).ToList();

            InProgress inProgress = new InProgress()
            {
                InProgressTodos = inProgressTasks
            };
            return View(inProgress);
        }

        public IActionResult DoneTasks()
        {
            var doneTasks = _John.ToDos.Where(t => t.Status == Status.Done).ToList();

            Done doneTodos = new Done()
            {
                DoneTodos = doneTasks
            };
            return View(doneTodos);
        }

  
        public IActionResult UserStatistic()
        {
            return View(_John);
        }
    }
}