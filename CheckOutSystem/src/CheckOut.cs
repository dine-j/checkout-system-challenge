using System.Collections.Generic;

namespace CheckoutSystem
{
    public class CheckOut
    {
        Dictionary<Item, int> basket;
        double total;

        public CheckOut()
        {
            basket = new Dictionary<Item, int>();
            total = 0;
        }

        public void Scan(Item item)
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

        public void Remove(Item item)
        {

        }

        public double Total()
        {
            return total;
        }
    }
}
