using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PierresBakeryTests : IDisposable
    {

        public void Dispose()
        {
            // Item.ClearAll();
        }

        [TestMethod]
        public void BreadConstructor_CreateInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(5);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void OrderedQuantity_OrderedBreadQuantiry_Int()
        {
            int orderedQuantity = 5;
            Bread newBread = new Bread(orderedQuantity);
            Assert.AreEqual(orderedQuantity, newBread.OrderedQuantity);
        }

        [TestMethod]
        public void FindTotalQuantity_CalculatedBreadQuantity_Int()
        {
            int orderedQty = 14;
            Bread newBread = new Bread(orderedQty);
            int totalQty = newBread.FindTotalQuantity();
            Assert.AreEqual(21, totalQty);
        }

        [TestMethod]
        public void FindTotalCost_CalculatedBreadOrderCost_Int()
        {
            int orderedQty = 10;
            Bread newBread = new Bread(orderedQty);
            int orderCost = newBread.FindTotalCost();
            Assert.AreEqual(50, orderCost);
        }
    }
}