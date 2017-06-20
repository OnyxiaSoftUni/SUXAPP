using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUXAPP.Core.Model
{
    public class CartItem
    {
        public CartItem()
        {
        }

        public HotDog HotDog
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }
    }
}