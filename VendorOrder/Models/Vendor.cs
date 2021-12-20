using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static int _instanceNumber = 0;
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = _instanceNumber ++;
      Orders = new List<Order> {};
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
      _instanceNumber = 0;
    }

    public static Vendor Find(int id)
    {
      return _instances.Find(vendor => vendor.Id == id);
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}