using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project
{
    public struct Order
    {
        public int orderNumber { get; set; }

        public string CustomerName { get; set; }
 
        public string CustomerPhone { get; set; } 

        public string Fishtype { get; set; } 

        public double Quantity { get; set; } 

        public double Price { get; set; }

        public double totalprice { get; set; }

        public bool isDeleted { get; set; }

    }
}
