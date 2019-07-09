using Academy.App.New.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.App.WebApp.Models
{
    public class AddStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public StudentAcademy Academy { get; set; }
    }
}
