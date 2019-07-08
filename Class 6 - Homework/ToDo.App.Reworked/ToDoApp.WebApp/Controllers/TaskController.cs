
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Domain;
using ToDoApp.Services.Services;
using ToDoApp.WebApp.Models;

namespace ToDoApp.WebApp.Controllers
{
    public class TaskController : Controller
    {
        private IToDoService _todoService;
        private IUserService _userService;

        public TaskController(IToDoService todoService, IUserService userService)
        {
            _todoService = todoService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            List<ToDo> notDoneTodos = _todoService.GetAllToDos()
                .Where(t => t.Status == Status.NotDone)
                .ToList();
            List<ToDoViewModel> notDoneView = new List<ToDoViewModel>();
            foreach (var toDo in notDoneTodos)
            {
                List<SubTaskViewModel> subTaskView = new List<SubTaskViewModel>();
                foreach (var subtask in toDo.SubTasks)
                {
                    subTaskView.Add(new SubTaskViewModel()
                    {
                        Title = subtask.Title,
                        Descrition = subtask.Descrition,
                        SubStatus = subtask.SubStatus
                    });
                }
                notDoneView.Add(new ToDoViewModel()
                {
                    Id = toDo.Id,
                    Title = toDo.Title,
                    Descrition = toDo.Descrition,
                    ImporanceOfTask = toDo.ImporanceOfTask,
                    TypeOfTodo = toDo.TypeOfToDo,
                    Status = toDo.Status,
                    SubTasks = subTaskView
                });

            }
            NotDoneTasksViewModel model = new NotDoneTasksViewModel()
            {
                NotDoneTasks = notDoneView
            };
            return View(model);
        }
        [HttpGet("AddSubTask")]
        public IActionResult AddSubTask()
        {
            return View(new AddSubTaskViewModel());
        }
        [HttpPost("AddSubTask")]
        public IActionResult AddSubTask(AddSubTaskViewModel model)
        {
            return RedirectToAction("AddTask", "Task", new { subtasks = model.NumberOfSubTask });
        }
        [HttpGet("AddTask")]
        public IActionResult AddTask(string error, int? subtasks)
        {
            if (error != null) return View("_Error");
            AddTaskViewModel modelToDo = new AddTaskViewModel();
            modelToDo.SubTasks = new List<SubTaskViewModel>();
            for (int i = 0; i < subtasks.Value; i++)
            {
                modelToDo.SubTasks.Add(new SubTaskViewModel());
            }
            return View(modelToDo);
        }
        [HttpPost("AddTask")]
        public IActionResult AddTask(AddTaskViewModel model)
        {
            List<SubTask> subtasks = new List<SubTask>();
            foreach (var subtask in model.SubTasks)
            {
                subtasks.Add(new SubTask()
                {
                    Title = subtask.Title,
                    Descrition = subtask.Descrition,
                    SubStatus = subtask.SubStatus
                });
            }
            ToDo todo = new ToDo()
            {
                Title = model.Title,
                Descrition = model.Description,
                ImporanceOfTask = model.ImporanceOfTask,
                Status = Status.NotDone,
                TypeOfToDo = model.TypeOfTodo,
                SubTasks = subtasks
            };
            _todoService.AddToDo(todo);
            return View("_ThankYou");
        }

        public IActionResult InProgress()
        {
            List<ToDo> InProgressTodos = _todoService.GetAllToDos()
                .Where(t => t.Status == Status.InProgress)
                .ToList();
            List<ToDoViewModel> inProgressView = new List<ToDoViewModel>();
            foreach (var toDo in InProgressTodos)
            {
                List<SubTaskViewModel> subTaskView = new List<SubTaskViewModel>();
                foreach (var subtask in toDo.SubTasks)
                {
                    subTaskView.Add(new SubTaskViewModel()
                    {
                        Title = subtask.Title,
                        Descrition = subtask.Descrition,
                        SubStatus = subtask.SubStatus
                    });
                }
                inProgressView.Add(new ToDoViewModel()
                {
                    Id = toDo.Id,
                    Title = toDo.Title,
                    Descrition = toDo.Descrition,
                    ImporanceOfTask = toDo.ImporanceOfTask,
                    TypeOfTodo = toDo.TypeOfToDo,
                    Status = toDo.Status,
                    SubTasks = subTaskView
                });

            }
            InProgressViewModel model = new InProgressViewModel()
            {
                InProgressTasks = inProgressView
            };
            return View(model);
        }

        public IActionResult DoneTodos()
        {
            List<ToDo> DoneTodos = _todoService.GetAllToDos()
                .Where(t => t.Status == Status.Done)
                .ToList();
            List<ToDoViewModel> DoneView = new List<ToDoViewModel>();
            foreach (var toDo in DoneTodos)
            {
                List<SubTaskViewModel> subTaskView = new List<SubTaskViewModel>();
                foreach (var subtask in toDo.SubTasks)
                {
                    subTaskView.Add(new SubTaskViewModel()
                    {
                        Title = subtask.Title,
                        Descrition = subtask.Descrition,
                        SubStatus = subtask.SubStatus
                    });
                }
                DoneView.Add(new ToDoViewModel()
                {
                    Id = toDo.Id,
                    Title = toDo.Title,
                    Descrition = toDo.Descrition,
                    ImporanceOfTask = toDo.ImporanceOfTask,
                    TypeOfTodo = toDo.TypeOfToDo,
                    Status = toDo.Status,
                    SubTasks = subTaskView
                });

            }
            DoneViewModel model = new DoneViewModel()
            {
                DoneTasks = DoneView
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult TaskDetails(int id)
        {
            ToDo todo = _todoService.GetToDoById(id);
            if (todo == null) return View("_Error");
            List<SubTaskViewModel> subtasks = new List<SubTaskViewModel>();
            foreach (var subtask in todo.SubTasks)
            {
                subtasks.Add(new SubTaskViewModel()
                {
                    Title = subtask.Title,
                    Descrition = subtask.Descrition,
                    SubStatus = subtask.SubStatus
                });
            }
            TaskDetailsViewModel taskDetail = new TaskDetailsViewModel()
            {
                Id = todo.Id,
                Title = todo.Title,
                Descrition = todo.Descrition,
                ImporanceOfTask = todo.ImporanceOfTask,
                Status = todo.Status,
                SubTasks = subtasks
            };
            return View(taskDetail);
        }

        [HttpPost]
        public IActionResult TaskDetails(TaskDetailsViewModel model)
        {
            List<SubTask> subtasks = new List<SubTask>();

            foreach (var subTaskModel in model.SubTasks)
            {
                subtasks.Add(new SubTask()
                {
                    //Id = subTaskModel.Id,
                    Title = subTaskModel.Title,
                    Descrition = subTaskModel.Descrition,
                    SubStatus = subTaskModel.SubStatus
                });
            }

            ToDo todo = _todoService.GetAllToDos().SingleOrDefault(t => t.Id == model.Id);
            todo.Title = model.Title;
            todo.Descrition = model.Descrition;
            todo.ImporanceOfTask = model.ImporanceOfTask;
            todo.Status = model.Status;
            todo.TypeOfToDo = model.TypeOfTodo;
            todo.SubTasks = subtasks;

            _todoService.UpdateTask(todo);
            return View("_ThankYou");
        }
    }
}
