﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUXAPP.Core.Model
{
    public class Cart
    {
        public Cart()
        {
        }

        public List<CartItem> CartItems
        {
            get;
            set;
        }
    }
}