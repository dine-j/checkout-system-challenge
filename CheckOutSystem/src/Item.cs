using System;

namespace CheckoutSystem
{
    public class Item : IEquatable<Item>
    {
        private String SKU;
        private double price;

        /// <summary>
        /// Constructor of Item
        /// </summary>
        /// <param name="SKU">SKU of the item</param>
        /// <param name="price">Price of the item</param>
        public Item(String SKU, double price)
        {
            this.SKU = SKU;
            this.price = price;
        }

        public String GetSKU()
        {
            return SKU;
        }
        
        public double GetPrice()
        {
            return price;
        }

        public bool Equals(Item other)
        {
            return !ReferenceEquals(null, other) && SKU.Equals(other.SKU);
        }

        public override int GetHashCode()
        {
            return SKU.GetHashCode();
        }
    }
}
