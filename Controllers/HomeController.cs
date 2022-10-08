using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Mapper;
using OrderManagement.Models;
using System.Threading;

namespace OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                OrderManagement_DataLayer.Order ord = new OrderManagement_DataLayer.Order();

                return View(ord.GetOrders().Select(a => a.Map()));
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(new List<Order>());
            }
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