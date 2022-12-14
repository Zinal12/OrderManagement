using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderManagement_DataLayer
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public string OrderNumber { get; set; }

        public string OrderName { get; set; }

        public int OrderQty { get; set; }

        public decimal OrderPrice { get; set; }

        [Display(Name = "Order Date")]
        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public string OrderStatus { get; set; }

    }
    class OrderStatus
    {
        public int Id { get; set; }

        public string StatusName { get; set; }
    }
}