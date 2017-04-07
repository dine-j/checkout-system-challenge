# Checkout System Coding Challenge

## Task

The goal is to implement the code for a shop checkout system that can scan and void items, as well as calculate their total price. Items are identified using Stock Keeping Units (SKUs), e.g. using individual letters of the alphabet (A, B, C, etc). Goods are either priced individually, or multi-priced: buy N of them, and they’ll cost you X pounds. For example, item ‘A’ might cost £50 individually, but this week’s special offer is buy three ‘A’s and they’ll cost you £130. Some example data might be:

| Item | Unit Price | Special Price |
|------|------------|---------------|
| A    | £50        | 3 for £130    |
| B    | £30        | 2 for £45     |
| C    | £20        |               |
| D    | £15        |               |

The checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at £45 (for a total price so far of £95). Because the pricing changes frequently, we need to be able to pass in a set of pricing rules each time we start handling a checkout transaction.
The final code should be able to be called along the lines of:

```C#
var co = new CheckOut(pricing_rules);

co.scan(itemA); // add an item of class A

co.scan(itemB); // add an item of class B

var priceSoFar = co.total(); // get subtotal

co.void(itemB); // remove an item of class B

co.scan(itemD); // add an item of class D

co.scan(itemA); // add an item of class A

etc

var totalPrice = co.total(); // get final total
```

## My approach

The 3 main classes are `Item`, `CheckOut` and a `PricingRule` interface. `CheckOut` can be constructed with a list of `PricingRules` and will take them in consideration when computing the total price of the current "basket". A new rule can be obtained by implementing `PricingRule` with a specific definition for the discount to be applied.
