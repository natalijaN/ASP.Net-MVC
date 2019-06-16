using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;

namespace ToDoApp.Models.ViewModels
{
    public class Done
    {
        public List<ToDo> DoneTodos { get; set; } = new List<ToDo>();
    }
}
