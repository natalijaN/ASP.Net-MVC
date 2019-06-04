using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;

namespace SEDC.App.Controllers
{
    //[Route("Start/[Action]")]
    public class HomeController : Controller
    {
        
    //[Route("Begin")]
    public IActionResult Index()
        {
            return View();
        }
        //[HttpGet("CallMe")]
        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public IActionResult Nothing()
        {
            return new EmptyResult();
        }
        public IActionResult BackToHome()
        {
            return RedirectToAction("Index");
        }
        public IActionResult JsonData()
        {
            object order = new { OrderId = 12, OrderName = "Zdrave" };
            return new JsonResult(order);
        }

        /*
        3. In the home controller create a view called Promotion
             * Send a pizza model made in the action to the view
             * In the view write a header saying "Today's Promotion" and in a paragraph
               write the properties values of the pizza in one line.

               **Bonus:** In the Order controller, in the index action send a list of 3 orders in the view. 
                Render the orders in an unordered list ( User name, what kind of pizza and price are the data 
                that should be shown )
        */
        public IActionResult Promotion()
        {
            ViewBag.Header = "Today`s Promotion";
            OrderController order = new OrderController();
            var pizzas = order._pizzasDb;
            Pizza pizza = pizzas[1];
            return View(pizza);
        }
    }
}