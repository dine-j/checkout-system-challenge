using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem
{
    public class CheckOut
    {
        Dictionary<Item, int> basket;
        double totalPrice;

        public CheckOut()
        {
            basket = new Dictionary<Item, int>();
            totalPrice = 0;
        }

        public void scan(Item item)
        {
            if(basket.ContainsKey(item))
            {
                ++basket[item];
            }
            else
            {
                basket.Add(item, 1);
            }
        }

        public void remove(Item item)
        {

        }

        public double total()
        {
            return totalPrice;
        }
    }
}
