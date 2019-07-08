using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToDoApp.Domain
{
    public class SubTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrition { get; set; }
        public virtual ToDo ToDo { get; set; }
        public int ToDoID { get; set; }
        public SubStatus SubStatus { get; set; }
    }
}
