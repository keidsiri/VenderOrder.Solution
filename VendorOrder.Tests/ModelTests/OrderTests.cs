using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests :IDisposable
  {
    public void Dispose()
    {
      
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "test";
      string description = "test";
      int price = 0;
      string date = "date";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_GetOrderTitle_Title()
    {
      string title = "Bread";
      string description = "test";
      int price = 0;
      string date = "date";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void OrderConstructor_GetDescriptionOrder_Description()
    {
      string title = "test";
      string description = "Sour Bread";
      int price = 0;
      string date = "date";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(description, newOrder.Description);
    }


  }
}