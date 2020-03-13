using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/new")]
    public ActionResult New(int id)
    {
      vendor vendor = vendor.Find(id);
      return View(vendor);
    }

    [HttpGet("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorID, int orderID)
    {
      Order order = Order.Find(orderID);
      Vendor vendor = Vendor.Find(vendorID);
      Dictionary <string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Delete(int orderID)
    {
      List<Order> order = Order.GetAll();
      int indexToDelete = order.FindIndex(order => order.Id == orderID);
      order.RemoveAt(indexToDelete);
      return RedirectToAction("Show", "Vendor");
    }
  }
}