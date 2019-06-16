using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models.DomainModels;
using Type = ToDoApp.Models.DomainModels.Type;

namespace ToDoApp.Models.ViewModels
{
    public class AddTaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Importance Of Task")]
        public ImporanceOfTask ImporanceOfTask { get; set; }
        [Display(Name = "Type Of Task")]
        public Type Type { get; set; }

        //Add SubTask
        [Display(Name = "Title of Subtask")]
        public string SubTaskTitle { get; set; }
        [Display(Name = "Description of Subtask")]
        public string SubTaskDescrition { get; set; }
        [Display(Name = "Subtask status")]
        public SubStatus SubStatus { get; set; }
    }
}
