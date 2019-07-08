using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToDoApp.Domain
{
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ImporanceOfTask ImporanceOfTask { get; set; }
        public Status Status { get; set; }
        public TypeOfTodo TypeOfToDo { get; set; }
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
    }
}
