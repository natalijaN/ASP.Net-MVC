using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.DomainModels;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult UserStatistic(User user)
        {
            var userStatistic = user;
            return View(userStatistic);
        }
    }
}