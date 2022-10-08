using OrderManagement_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Mapper;
using OrderManagement.Models;
using System.Threading;
using Order = OrderManagement.Models.Order;

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
    }
}