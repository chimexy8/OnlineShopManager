using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopmanager.Models
{
    public class Sale
    {
        public int ID { get; set; }

        public double TransactionID { get; set; }

        public DateTime Date { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal Amountpaid { get; set; }

        public decimal Balance { get; set; }
    }
}
