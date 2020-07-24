using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests //:  IDisposable
  {
    // public void Dispose()
    // {
    //  Vendor.ClearAll();

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzy's Boulangerie", "A bakery downtown");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzy's Boulangerie";
      string description = "A bakery downtown";
      Vendor newVendor = new Vendor(name, description);
      string nameResult = "test name";
      string descriptionResult = "test description";
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }

    [TestMethod]
    public void getDescription_ReturnsDescription_String()
    {
      string name = "Suzy's Boulangerie";
      string description = "A bakery downtown";
      Vendor newVendor = new Vendor(name, description);
      string descriptionResult = "test description";
      Assert.AreEqual(description, descriptionResult);



    }
  }
}