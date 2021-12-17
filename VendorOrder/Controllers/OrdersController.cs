using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order newOrder= new Order(title, description, date, price);
      return RedirectToAction("Show");
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order foundOrder = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", foundOrder);
      model.Add("vender", vendor);
      return View(model);
    }
  }
}