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
    public class ItemTests
    {
        [TestMethod()]
        public void GetTotalTest1()
        {
            Item a = new Item("A", 50);
            Assert.AreEqual(a.GetTotal(1), 50);
        }

        [TestMethod()]
        public void GetTotalTest2()
        {
            Item a = new Item("A", 50, 3, 130);
            Assert.AreEqual(a.GetTotal(3), 130);
        }

        [TestMethod()]
        public void GetTotalTest3()
        {
            Item a = new Item("A", 50, 3, 130);
            Assert.AreEqual(a.GetTotal(6), 260);
        }

        [TestMethod()]
        public void GetTotalTest4()
        {
            Item a = new Item("A", 50, 3, 130);
            Assert.AreEqual(a.GetTotal(5), 230);
        }
    }
}