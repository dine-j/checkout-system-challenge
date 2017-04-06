using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CheckOutSystem.src;
using CheckOutSystem.src.example;

namespace CheckoutSystem.Tests
{
    [TestClass()]
    public class CheckOutTests
    {
        [TestMethod()]
        public void ScanNewItemTest()
        {
            CheckOut co = new CheckOut();
            Item a = new Item("A", 50);
            co.Scan(a);
            Assert.AreEqual(co.GetBasket()[a], 1);
        }

        [TestMethod()]
        public void ScanExistingItemTest()
        {
            CheckOut co = new CheckOut();
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Scan(a);
            Assert.AreEqual(co.GetBasket()[a], 2);
        }

        [TestMethod()]
        public void RemoveTest1()
        {
            CheckOut co = new CheckOut();
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Scan(a);
            co.Remove(a);
            Assert.AreEqual(co.GetBasket()[a], 1);
        }

        [TestMethod()]
        public void RemoveTest2()
        {
            CheckOut co = new CheckOut();
            Item a = new Item("A", 50);
            co.Scan(a);
            co.Remove(a);
            Assert.IsFalse(co.GetBasket().ContainsKey(a));
        }

        [TestMethod()]
        public void TotalTest1()
        {
            CheckOut co = new CheckOut();
            Item a = new Item("A", 50);
            Item b = new Item("B", 30);
            co.Scan(a);
            co.Scan(b);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 130);
        }

        [TestMethod()]
        public void TotalTest2()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            Item b = new Item("B", 30);
            co.Scan(a);
            co.Scan(b);
            co.Scan(a);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 160);
        }

        [TestMethod()]
        public void TotalTest3()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            rules.Add(new ItemBSpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            Item b = new Item("B", 30);
            co.Scan(a);
            co.Scan(b);
            co.Scan(a);
            co.Scan(b);
            Assert.AreEqual(co.Total(), 145);
        }

        [TestMethod()]
        public void TotalTest4()
        {
            List<PricingRule> rules = new List<PricingRule>();
            rules.Add(new ItemASpecialPrice());
            rules.Add(new ItemBSpecialPrice());
            CheckOut co = new CheckOut(rules);
            Item a = new Item("A", 50);
            Item b = new Item("B", 30);
            co.Scan(a);
            co.Scan(b);
            co.Scan(a);
            co.Scan(b);
            co.Scan(a);
            Assert.AreEqual(co.Total(), 175);
        }
    }
}