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

    [TestMethod]
    public void OrderConstructor_GetOrderPrice_Int()
    {
      string title = "test";
      string description = "Sour Bread";
      int price = 5;
      string date = "date";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(price, newOrder.Price);
    }

    [TestMethod]
    public void OrderConstructor_GetOrderDate_Date()
    {
      string title = "test";
      string description = "Sour Bread";
      int price = 0;
      string date = "December 17";
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void OrderConstructor_GetOrderID_Int()
    {      
      string title = "title";
      string description = "description";
      string date = "date";
      int price = 10;
      Order newOrder = new Order(title, description, date, price);
      Assert.AreEqual(0,  newOrder.Id);
    }

    // [TestMethod]
    // public void GetAll_ReturnEmptyList_OrderList()
    // {
    //   List<Order> emptyList = new List<Order>{};
    //   List<Order> resultList = Order.GetAll();
    //   CollectionAssert.AreEqual(emptyList, resultList);
    // }

    // [TestMethod]
    // public void OrderConstructor_AutoAddsOrderToList_List()
    // {
    //   string title = "title";
    //   string description = "description";
    //   int price = 10;
    //   string date = "date";
    //   Order newOrder = new Order(title, description, date, price);
    //   List<Order> newList = new List<Order>{};
    //   List<Order> testList = Order.GetAll();
    //   newList.Add(newOrder);
    //   CollectionAssert.AreEqual(newList,testList);
    // }



  }
}