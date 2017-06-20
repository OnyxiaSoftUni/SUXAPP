using SUXAPP.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUXAPP.Core.Repository
{
    public class CartRepository
    {
        public CartRepository()
        {
        }

        private static Cart MainCart = new Cart() { CartItems = new List<CartItem>() };

        public void AddCartItem(HotDog hotDog, int amount)
        {
            //TODO: add check if already added
            MainCart.CartItems.Add(new CartItem() { HotDog = hotDog, Amount = amount });
        }

        public Cart GetCart()
        {
            return MainCart;
        }
    }
}