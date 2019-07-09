using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.App.WebApp.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int EstimatedTime { get; set; }
        public int TimeSpent { get; set; }
    }
}
