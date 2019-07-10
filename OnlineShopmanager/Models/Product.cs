using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopmanager.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string ProductName { get; set; }

        public string CategoryName { get; set; }

        public decimal Amount { get; set; }

        public int StockedQuantity { get; set; }

        public int ReorderLevel { get; set; }
    }
}
