using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public ImporanceOfTask ImporanceOfTask { get; set; }
        public Status Status { get; set; }
        public TypeOfTodo TypeOfToDo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }
}
