﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.Entities
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }


    }
}
