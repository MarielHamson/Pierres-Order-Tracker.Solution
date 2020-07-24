using System.Collections.Generic;
namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _instances.Add(this);
      Orders = new List<Order> { };
    }

    // properties, methods, etc. will go here.

  }
}