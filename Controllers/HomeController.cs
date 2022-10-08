using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Models;
using OrderManagement.Controllers;


namespace OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OrderPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UpdatePage()
        {
            
            var status = new List<OrderStatus>()
            {
                new OrderStatus(){Id=1, StatusName="Approved"},
                new OrderStatus(){Id=2, StatusName="Pending"},
                new OrderStatus(){Id=3, StatusName="Active"},
                new OrderStatus(){Id=4, StatusName="InTransit"},
                new OrderStatus(){Id=5, StatusName="Delivered"},
            };
            ViewBag.list = status;
            return View();
        }


        [HttpPost]
        public ActionResult UpdatePage(Order ord)
        {

            if(ModelState.IsValid)
            {
                return RedirectToAction("UpdatePage");
            }

            var status = new List<OrderStatus>()
            {
                new OrderStatus(){Id=1, StatusName="Approved"},
                new OrderStatus(){Id=2, StatusName="Pending"},
                new OrderStatus(){Id=3, StatusName="Active"},
                new OrderStatus(){Id=4, StatusName="InTransit"},
                new OrderStatus(){Id=5, StatusName="Delivered"},
            };
            ViewBag.list = status;
            return View();
        }
    }
    
}