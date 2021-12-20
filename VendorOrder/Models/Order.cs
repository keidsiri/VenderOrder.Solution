using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get ; set; }
    public string Description { get; set; }
    public string Date {get; set; }
    public int Price {get; set; }
    public int Id {get; }
    private static List<Order> _instances = new List<Order>() { };

    public Order(string title, string description, string date, int price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int id)
    {
      return _instances[id - 1];
    }

    public static void DeleteOrder(int id)
    {
      Order deletOrder = Order.Find(id);
      _instances.Remove(deletOrder);
    }

  }
}