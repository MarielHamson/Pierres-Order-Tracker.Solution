using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
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
      Vendor newVendor = new Vendor("Suzy's Boulangerie", "A bakery downtown");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Suzy's Boulangerie";
      string description = "A bakery downtown";
      Vendor newVendor = new Vendor(name, description);
      string nameResult = newVendor.Name;
      Assert.AreEqual(name, nameResult);
    }

    [TestMethod]
    public void getDescription_ReturnsDescription_String()
    {
      string name = "Suzy's Boulangerie";
      string description = "A bakery downtown";
      Vendor newVendor = new Vendor(name, description);
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(description, descriptionResult);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Suzy's Boulangerie";
      string description = "A bakery downtown";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Suzy's Boulangerie";
      string description01 = "A bakery downtown";
      string name02 = "Abigail's Abbattoire";
      string description02 = "A butcher shop in town";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = new List<Vendor> { newVendor1, newVendor2 };
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void FindVendor_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Suzy's Boulangerie";
      string description01 = "A bakery downtown";
      string name02 = "Abigail's Abbattoire";
      string description02 = "A butcher shop in town";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor2, result);
    }
  }
}
