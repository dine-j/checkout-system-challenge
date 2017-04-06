using CheckoutSystem;
using System.Collections.Generic;

namespace CheckOutSystem.src
{
    public interface PricingRule
    {
        double ApplyRule(Dictionary<Item, int> basket);
    }
}
