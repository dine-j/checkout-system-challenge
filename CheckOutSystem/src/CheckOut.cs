using System.Collections.Generic;

namespace CheckoutSystem
{
    public class CheckOut
    {
        Dictionary<Item, int> basket;

        public CheckOut()
        {
            basket = new Dictionary<Item, int>();
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
            double total = 0;
            foreach(Item item in basket.Keys)
            {
                total += item.GetTotal(basket[item]);
            }
            return total;
        }

        public Dictionary<Item, int> GetBasket()
        {
            return basket;
        }
    }
}
