using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        private List<User> _users = new List<User>();
        public TaskController()
        {

            User john = new User()
            {
                FirstName = "John",
                LastName = "Doe",
                AverageFreeTime = 5

            };

            User will = new User()
            {
                FirstName = "Will",
                LastName = "Smith",
                AverageFreeTime = 3
            };

            _users.Add(john);
            _users.Add(will);

            ToDo basketball = new ToDo()
            {
                Title = "Basketball Training",
                ImporanceOfTask = ImporanceOfTask.MediumImportant,
                Status = Status.InProgress,
                Type = Models.DomainModels.Type.Hobby,
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
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.NotDone,
                Type = Models.DomainModels.Type.Work,
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
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.Done,
                Type = Models.DomainModels.Type.Personal,
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

        }

        public IActionResult NotDoneTasks()
        {
            return View();
        }

        public IActionResult InProgressTasks()
        {
            return View();
        }

        public IActionResult DoneTasks()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckUser(User newUser)
        {
            var user = _users.Where(u => u.FirstName == "John").FirstOrDefault();
            Console.WriteLine(user.FirstName);
            return RedirectToAction("UserStatistic", "Home", new { user = newUser });
        }
    }
}