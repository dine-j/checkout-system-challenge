﻿using System;

namespace CheckoutSystem
{
    public class Item : IEquatable<Item>
    {
        String name;
        double price;
        int thresholdDiscount;
        double discountedPrice;

        public Item(String name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public Item(String name, double price, int thresholdDiscount, double discountedPrice)
        {
            this.name = name;
            this.price = price;
            this.thresholdDiscount = thresholdDiscount;
            this.discountedPrice = discountedPrice;
        }

        public double GetTotal(int quantity)
        {
            if(thresholdDiscount != 0)
            {
                int discountCoefficient = quantity / thresholdDiscount;
                quantity -= thresholdDiscount * discountCoefficient;
                return price * quantity + discountCoefficient * discountedPrice;
            }
            return price * quantity;
        }

        public bool Equals(Item other)
        {
            return !ReferenceEquals(null, other) && name.Equals(other.name);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
