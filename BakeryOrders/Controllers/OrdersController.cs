using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorID, int orderID)
    {
      Order order = Order.Find(orderID);
      Vendor vendor = Vendor.Find(vendorID);
      Dictionary <string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Delete(int orderID)
    {
      List<Order> orders = Order.GetAll();
      int indexToDelete = orders.FindIndex(order => order.Id == orderID);
      orders.RemoveAt(indexToDelete);
      return RedirectToAction("Show", "Vendor");
    }
  }
}