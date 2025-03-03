﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerShop.Domain.Model
{
    public class ShoppingCartItem
    {
        public ShoppingCartItem(int id, decimal price)
        {
            Id = id;
            Price = price;
        }

        public int Id { get; private set; }
        public decimal Price { get; set; }
        public int Pieces { get; set; }

        public int ProductNavigationId { get; set; }
        public Product ProductNavigation { get; set; } = default!;
    }
}
