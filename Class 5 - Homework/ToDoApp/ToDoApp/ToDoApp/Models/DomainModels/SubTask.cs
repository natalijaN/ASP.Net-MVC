using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models.DomainModels
{
    public enum SubStatus
    {
        Done,
        NotDone
    }

    public class SubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public SubStatus SubStatus { get; set; }
    }
}
