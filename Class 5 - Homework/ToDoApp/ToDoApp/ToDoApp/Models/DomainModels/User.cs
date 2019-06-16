    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AverageFreeTime { get; set; }
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();
    }
}
