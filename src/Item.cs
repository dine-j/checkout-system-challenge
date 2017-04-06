using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem
{
    class Item : IEquatable<Item>
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
