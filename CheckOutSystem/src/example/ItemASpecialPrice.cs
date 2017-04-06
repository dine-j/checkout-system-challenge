using CheckOutSystem.src;
using System.Collections.Generic;
using CheckoutSystem;

namespace CheckOutSystemTests.src
{
    public class ItemASpecialPrice : PricingRule
    {
        public double ApplyRule(Dictionary<Item, int> basket)
        {
            double discount = 0;
            foreach(Item item in basket.Keys)
            {
                if(item.GetSKU().Equals("A"))
                {
                    double normalPrice = item.GetPrice() * basket[item];
                    int discountCoefficient = basket[item] / 3;
                    double discountedPrice = discountCoefficient * 130;
                    discount = normalPrice - discountedPrice;
                }
            }
            return discount;
        }
    }
}
