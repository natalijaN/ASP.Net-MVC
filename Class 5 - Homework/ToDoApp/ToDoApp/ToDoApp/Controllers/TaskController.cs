using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;
using ToDoApp.Models.ViewModels;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {

        public IActionResult NotDoneTasks()
        {
            var notDoneTasks = Db.Users.FirstOrDefault(u => u.FirstName == "John")
                .ToDos.Where(t => t.Status == Status.NotDone).ToList();

            NotDone notDone = new NotDone()
            {
                NotDoneTodos = notDoneTasks
            };
            return View(notDone);
        }

        public IActionResult InProgressTasks()
        {
            var inProgressTasks = Db.Users.FirstOrDefault(u => u.FirstName == "John")
                .ToDos.Where(t => t.Status == Status.InProgress).ToList();

            InProgress inProgress = new InProgress()
            {
                InProgressTodos = inProgressTasks
            };
            return View(inProgress);
        }

        public IActionResult DoneTasks()
        {
            var doneTasks = Db.Users.FirstOrDefault(u => u.FirstName == "John")
                .ToDos.Where(t => t.Status == Status.Done).ToList();

            Done doneTodos = new Done()
            {
                DoneTodos = doneTasks
            };
            return View(doneTodos);
        }


        public IActionResult UserStatistic()
        {
            var NewUser = Db.Users.FirstOrDefault(u => u.FirstName == "John");

            return View(NewUser);
        }
        [HttpGet("AddTask")]
        public IActionResult AddTask(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            AddTaskModel model = new AddTaskModel();
            return View(model);
        }


        [HttpPost("AddTask")]
        public IActionResult AddTask(AddTaskModel model)
        {

            Db.ToDoId++;
            Db.SubTaskId++;

            ToDo todo = new ToDo()
            {
                Id = Db.ToDoId,
                Title = model.Title,
                Descrition = model.Description,
                ImporanceOfTask = model.ImporanceOfTask,
                Status = Status.NotDone,
                Type = model.Type,
           
            };

            SubTask subtask = new SubTask()
            {
                Id = Db.SubTaskId,
                Title = model.SubTaskTitle,
                Descrition = model.SubTaskDescrition,
                SubStatus = model.SubStatus
            };

            todo.SubTasks.Add(subtask);

            Db.Users.FirstOrDefault(u => u.FirstName == "John").ToDos.Add(todo);

            return View("_AddedTask");
        }

    }

}
