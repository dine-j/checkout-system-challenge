using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void TotalTest()
        {
            Item a = new Item("A", 50);
            Item b = new Item("B", 30, 2, 45);
            CheckOut co = new CheckOut();
            co.Scan(a);
            co.Scan(b);
            co.Scan(b);
            Assert.AreEqual(co.Total(), 95);
        }
    }
}