using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;


namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectVendor.Orders;
      model.Add("vendor", selectVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

  }
}