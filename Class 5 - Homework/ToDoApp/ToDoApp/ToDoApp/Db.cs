using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;

namespace ToDoApp
{
    public static class Db
    {
        public static List<User> Users = new List<User>();
        public static int ToDoId;
        public static int UserId;
        public static int SubTaskId;

        static Db()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                AverageFreeTime = 5
            };

            Users.Add(john);

            ToDo basketball = new ToDo()
            {
                Id = 1,
                Title = "Basketball Training",
                ImporanceOfTask = ImporanceOfTask.Medium,
                Status = Status.InProgress,
                Type = Models.DomainModels.Type.Hobby,
            };

            SubTask workout = new SubTask()
            {
                Id = 1,
                Title = "Workout",
                Descrition = "Workout before Training",
                SubStatus = SubStatus.NotDone
            };

            SubTask spa = new SubTask()
            {
                Id = 2,
                Title = "Spa",
                Descrition = "Spa after Training",
                SubStatus = SubStatus.NotDone
            };

            basketball.SubTasks.Add(workout);
            basketball.SubTasks.Add(spa);

            ToDo project = new ToDo()
            {
                Id = 2,
                Title = "Project",
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.NotDone,
                Type = Models.DomainModels.Type.Work,
            };

            SubTask analyze = new SubTask()
            {
                Id = 3,
                Title = "Analyze",
                Descrition = "Analyze Data",
                SubStatus = SubStatus.Done
            };

            SubTask design = new SubTask()
            {
                Id = 4,
                Title = "Design",
                Descrition = "Design Engine",
                SubStatus = SubStatus.NotDone
            };

            project.SubTasks.Add(analyze);
            project.SubTasks.Add(design);


            ToDo readABook = new ToDo()
            {
                Id = 3,
                Title = "Reading Book",
                ImporanceOfTask = ImporanceOfTask.Important,
                Status = Status.Done,
                Type = Models.DomainModels.Type.Personal,
            };

            SubTask goToLibrary = new SubTask()
            {
                Id = 5,
                Title = "Go to the library",
                Descrition = "Go to the library",
                SubStatus = SubStatus.Done
            };

            SubTask readTheBook = new SubTask()
            {
                Id = 6,
                Title = "ReadTheBook",
                SubStatus = SubStatus.NotDone
            };

            readABook.SubTasks.Add(goToLibrary);
            readABook.SubTasks.Add(readTheBook);

            john.ToDos.Add(basketball);
            john.ToDos.Add(project);
            john.ToDos.Add(readABook);

            UserId = 1;
            ToDoId = 3;
            SubTaskId = 6;
        }
    }
}
