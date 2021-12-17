using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VenderOrder.Models;
using System;


namespace VenderOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "test";
      string description = "test";
      string date = "date";
      int price = 0;
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}