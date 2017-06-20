using SUXAPP.Core.Model;
using SUXAPP.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUXAPP.Core
{
    public class CartDataService
    {
        private static CartRepository cartRepository = new CartRepository();

        public CartDataService()
        {
        }

        public void AddCartItem(HotDog hotDog, int amount)
        {
            cartRepository.AddCartItem(hotDog, amount);
        }

        public Cart GetCart()
        {
            return cartRepository.GetCart();
        }
    }
}