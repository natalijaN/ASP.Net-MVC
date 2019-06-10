using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models.DomainModels
{
    public enum ImporanceOfTask
    {
        Important = 1,
        MediumImportant,
        NotImportant
    }

    public enum Status
    {
        NotDone,
        InProgress,
        Done
    }

    public enum Type
    {
        Work,
        Personal,
        Hobby
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
