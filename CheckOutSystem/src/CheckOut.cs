using CheckOutSystem.src;
using System.Collections.Generic;

namespace CheckoutSystem
{
    public class CheckOut
    {
        Dictionary<Item, int> basket;
        private List<PricingRule> pricingRules;

        public CheckOut(List<PricingRule> pricingRules)
        {
            basket = new Dictionary<Item, int>();
            this.pricingRules = pricingRules;
        }

        public CheckOut()
        {
            basket = new Dictionary<Item, int>();
        }

        /// <summary>
        /// Scan an item and add it to the "basket"
        /// </summary>
        /// <param name="item">Item to be added</param>
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

        /// <summary>
        /// Remove an item from the current "basket"
        /// </summary>
        /// <param name="item">Item to be removed</param>
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

        /// <summary>
        /// Get total price for current basket
        /// </summary>
        /// <returns></returns>
        public double Total()
        {
            double total = 0;
            foreach(Item item in basket.Keys)
            {
                total += item.GetPrice() * basket[item];
            }
            foreach(PricingRule rule in pricingRules)
            {
                total -= rule.ApplyRule(basket);
            }
            return total;
        }

        public Dictionary<Item, int> GetBasket()
        {
            return basket;
        }
    }
}
