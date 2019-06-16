using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models.DomainModels
{
    public enum ImporanceOfTask
    {
        Important = 1,
        Medium = 2,
        NotImportant = 3
    }

    public enum Status
    {
        NotDone = 1,
        InProgress = 2,
        Done = 3
    }

    public enum Type
    {
        Work = 1,
        Personal = 2,
        Hobby = 3
    }

    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public ImporanceOfTask ImporanceOfTask { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }


}
