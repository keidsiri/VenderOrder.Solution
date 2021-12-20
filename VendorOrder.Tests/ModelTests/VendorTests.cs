using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;


namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  { 
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_GetVendorName_String()
    {
      string name = "Vendor Name";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_ReturnVendorDescription_String()
    {
      string name = "Kate Bakery";
      string description = "Modern Bakery Shop";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(description, newVendor.Description);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Name";
      string description = "Description";
      Vendor newVendor = new Vendor( name, description);
      int result = newVendor.Id;
      Assert.AreEqual(0, result);
    }


  }
}