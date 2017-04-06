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
            if (basket.ContainsKey(item))
            {
               if(basket[item] > 1)
                {
                    --basket[item];
                }
               else
                {
                    basket.Remove(item);
                }
            }
        }

        public double Total()
        {
            return total;
        }

        public Dictionary<Item, int> GetBasket()
        {
            return basket;
        }
    }
}
