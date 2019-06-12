using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.Enums;

namespace ToDoApp.Models.DomainModels
{
   
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public ImportanceOfTask ImporanceOfTask { get; set; }
        public Status Status { get; set; }
        public TypeOfToDo Type { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }


}
