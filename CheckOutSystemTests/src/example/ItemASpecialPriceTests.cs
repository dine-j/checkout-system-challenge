using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CheckoutSystem;
using CheckOutSystem.src;
using CheckOutSystem.src.example;

namespace CheckOutSystemTests.src.Tests
{
    [TestClass()]
    public class ItemASpecialPriceTests
    {
        [TestMethod()]
        public void ApplyRuleTest1()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 130);
        }

        [TestMethod()]
        public void ApplyRuleTest2()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 260);
        }

        [TestMethod()]
        public void ApplyRuleTest3()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 180);
        }
    }
}