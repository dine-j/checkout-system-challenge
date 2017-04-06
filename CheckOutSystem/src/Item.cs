using System;

namespace CheckoutSystem
{
    public class Item : IEquatable<Item>
    {
        String name;
        double price;
        int thresholdDiscount;
        double discountedPrice;

        /// <summary>
        /// Constructor for item priced individually
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="price">Price of the item</param>
        public Item(String name, double price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Constructor for multi-priced item
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="price">Price of the item</param>
        /// <param name="thresholdDiscount">Number of required item to activate the discount</param>
        /// <param name="discountedPrice">Price for given number of items</param>
        public Item(String name, double price, int thresholdDiscount, double discountedPrice)
        {
            this.name = name;
            this.price = price;
            this.thresholdDiscount = thresholdDiscount;
            this.discountedPrice = discountedPrice;
        }

        /// <summary>
        /// Get total price for this item given a quantity
        /// </summary>
        /// <param name="quantity">Quantity needed</param>
        /// <returns>Total price for the item</returns>
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
