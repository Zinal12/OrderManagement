using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Models
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

        public OrderStatus orderStatus { get; set; }
    
    }
}