using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem
{
    class CheckOut
    {
        Dictionary<Item, int> basket;
        double totalPrice;

        CheckOut()
        {
            basket = new Dictionary<Item, int>();
            totalPrice = 0;
        }

        void scan(Item item)
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

        void remove(Item item)
        {

        }

        double total()
        {
            return totalPrice;
        }
    }
}
