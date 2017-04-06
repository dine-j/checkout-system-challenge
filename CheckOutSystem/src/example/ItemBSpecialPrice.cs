using CheckoutSystem;
using System.Collections.Generic;

namespace CheckOutSystem.src.example
{
    public class ItemBSpecialPrice : PricingRule
    {
        public double ApplyRule(Dictionary<Item, int> basket)
        {
            double discount = 0;
            foreach (Item item in basket.Keys)
            {
                if (item.GetSKU().Equals("B"))
                {
                    double individualPrice = item.GetPrice();
                    double normalTotalPrice = individualPrice * basket[item];
                    int discounTedItemNumber = basket[item] / 2;
                    int normalPriceNumber = basket[item] % 2;
                    double discountedPrice = discounTedItemNumber * 45 + normalPriceNumber * individualPrice;
                    discount = normalTotalPrice - discountedPrice;
                }
            }
            return discount;
        }
    }
}
