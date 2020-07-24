using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("croissants", "catering order", 50, "jan 1");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void SetTitle_UpdateTitleOfOrder_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string updatedTitle = "sponge cakes";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void SetDescription_UpdateDescriptionOfOrder_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string updatedDescription = "birthday party";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void SetPrice_UpdatePriceOfOrder_Int()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      int updatedPrice = 75;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }
    [TestMethod]
    public void SetDate_UpdateDateOfOrder_String()
    {
      string title = "croissants";
      string description = "catering order";
      int price = 50;
      string date = "jan 1";
      Order newOrder = new Order(title, description, price, date);
      string updatedDate = "Aug 13";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }
  }
}