﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopmanager.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public decimal payments { get; set; }

        public decimal Balance { get; set; }
    }
}
