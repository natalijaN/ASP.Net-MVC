using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain
{
    public class SubTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public SubStatus SubStatus { get; set; }
        public int ToDoId { get; set; }
        public ToDo Todo { get; set; }
    }
}
