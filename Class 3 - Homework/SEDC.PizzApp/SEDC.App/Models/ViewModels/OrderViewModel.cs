using SEDC.App.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.App.Models.ViewModels
{
    public class OrderViewModel
    {
        public string FirstPizza { get; set; }
        public int NumberOfOrders { get; set; }
        public string FirstPersonName { get; set; }
        public List<Order> NewOrder { get; set; } = new List<Order>();
    }
}
