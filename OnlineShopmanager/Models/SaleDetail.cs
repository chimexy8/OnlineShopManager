using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopmanager.Models
{
    public class SaleDetail
    {
        public int ID { get; set; }

        public double TransactionID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }
    }
}
