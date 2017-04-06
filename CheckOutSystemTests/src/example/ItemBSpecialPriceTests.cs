using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckOutSystem.src.example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckoutSystem;

namespace CheckOutSystem.src.example.Tests
{
    [TestClass()]
    public class ItemBSpecialPriceTests
    {
        [TestMethod()]
        public void ApplyRuleTest1()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemBSpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item b = new Item("B", 30);
            co.Scan(b);
            co.Scan(b);
            Assert.AreEqual(co.Total(), 45);
        }

        [TestMethod()]
        public void ApplyRuleTest2()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemBSpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item b = new Item("B", 30);
            co.Scan(b);
            co.Scan(b);
            co.Scan(b);
            Assert.AreEqual(co.Total(), 75);
        }

        [TestMethod()]
        public void ApplyRuleTest3()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemBSpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item b = new Item("B", 30);
            co.Scan(b);
            co.Scan(b);
            co.Scan(b);
            co.Scan(b);
            Assert.AreEqual(co.Total(), 90);
        }
    }
}