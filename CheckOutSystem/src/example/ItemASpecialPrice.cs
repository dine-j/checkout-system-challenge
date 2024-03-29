﻿using CheckOutSystem.src;
using System.Collections.Generic;
using CheckoutSystem;

namespace CheckOutSystem.src.example
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
                    double individualPrice = item.GetPrice();
                    double normalTotalPrice = individualPrice * basket[item];
                    int discounTedItemNumber = basket[item] / 3;
                    int normalPriceNumber = basket[item] % 3;
                    double discountedPrice = discounTedItemNumber * 130 + normalPriceNumber * individualPrice;
                    discount = normalTotalPrice - discountedPrice;
                }
            }
            return discount;
        }
    }
}
