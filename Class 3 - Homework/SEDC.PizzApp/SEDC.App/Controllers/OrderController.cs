using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;
using SEDC.App.Models.ViewModels;

namespace SEDC.App.Controllers
{
    public class OrderController : Controller
    {
        private List<Order> _ordersDb;
        public List<Pizza> _pizzasDb;
        public List<Order> _newOrdersDb;

        public OrderController()
        {
            User bob = new User()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "Bob Street",
                Phone = 080012312345
            };
            User jill = new User()
            {
                FirstName = "Jill",
                LastName = "Wayne",
                Address = "Jill Street",
                Phone = 08006546345
            };

            Pizza bianka = new Pizza()
            {
                Id = 1,
                Name = "Bianka",
                Size = "Small",
                Price = 5.4
            };

            Pizza kapri = new Pizza()
            {
                Id = 2,
                Name = "Kapri",
                Size = "Medium",
                Price = 6.3
            };

            Pizza bacon = new Pizza()
            {
                Id = 1,
                Name = "Bacon",
                Size = "Large",
                Price = 8.2
            };

            _pizzasDb = new List<Pizza>() { bianka, kapri, bacon };

            _ordersDb = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = bob,
                    Pizza = kapri,
                    Price = kapri.Price
                },
                new Order()
                {
                    Id = 2,
                    User = bob,
                    Pizza = bianka,
                    Price = bianka.Price
                },
                new Order()
                {
                    Id = 3,
                    User = jill,
                    Pizza = bacon,
                    Price = bacon.Price
                }
            };
            _newOrdersDb = new List<Order>()
            {
                new Order()
                {
                    Id = 4,
                    User = bob,
                    Pizza = kapri,
                    Price = kapri.Price
                },
                new Order()
                {
                    Id = 5,
                    User = jill,
                    Pizza = bianka,
                    Price = bianka.Price
                },
                new Order()
                {
                    Id = 4,
                    User = bob,
                    Pizza = bianka,
                    Price = bianka.Price
                }
            };
        }

        [Route("Orders")]
        public IActionResult Index()
        {
            //ViewData.Add("Title", "Welcome to the Orders page!");
            ViewBag.Title = "Welcome to the Orders page!";
            Order firstOrder = _ordersDb[0];
            OrderViewModel ordersViewModel = new OrderViewModel()
            {
                FirstPizza = firstOrder.Pizza.Name,
                NumberOfOrders = _ordersDb.Count,
                FirstPersonName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}",
                NewOrder = _newOrdersDb
             
            };

            //ViewBag.Orders = _newOrdersDb;

            return View(ordersViewModel);
        }
        public IActionResult Details(int? id)
        {
            #region ViewBag and ViewData
            //ViewData.Add("Title", "These are your orders:");
            //ViewData["Title"] = "These are your orders:";
            #endregion
            #region FirstOrDefault solution
            Order order = _ordersDb.FirstOrDefault(x => x.Id == id);
            if (order != null)
            {
                ViewBag.Title = $"This is order no. {order.Id}";
                return View(order);
            }
            return RedirectToAction("Index");
            #endregion
            #region try/catch solution
            //try
            //{
            //    Order order = _ordersDb.Find(x => x.Id == id);
            //    ViewBag.Title = $"This is order no. {order.Id}";
            //    if (order != null) return View(order);
            //}
            //catch
            //{
            //    return RedirectToAction("Index");
            //}
            //return RedirectToAction("Index");
            #endregion
            #region Redirecting to a different controller
            //return RedirectToAction("Index", "Home");
            #endregion
        }
    }
}