using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
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
        public ActionResult Create(string vendorName)
        {
            Vendor newVendor = new Vendor(vendorName);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/vendors/{vendorId}")]
        public ActionResult Show(int vendorId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string name, string description, int price, int date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(name, description, price, date);
            selectedVendor.AddOrder(newOrder);
            List<Order> venderOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", venderOrders);
            return View("Show", model);
        }
    }
}