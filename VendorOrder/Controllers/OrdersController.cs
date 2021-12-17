using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {

    // [HttpGet("/vendors/{vendorId}/orders/new")]
    // public ActionResult New(int vendorId)
    // {
    //   Vendor Vendor = Vendor.Find(vendorId);
    //   return View(Vendor);
    // }

    // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    // public ActionResult Show(int vendorId, int orderId)
    // {
    //   Order foundOrder = Order.Find(orderId);
    //   Vendor Vendor = Vendor.Find(vendorId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("album", foundOrder);
    //   model.Add("artist", Vendor);
    //   return View(model);
    // }
  }
}