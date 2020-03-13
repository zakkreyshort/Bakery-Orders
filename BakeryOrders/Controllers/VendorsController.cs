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
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Order;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }

        [HttpPost("/vendors/{id}/order")]
        public ActionResult Create(int vendorId, string name, string description, int price, int date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(name, description, price, date);
            selectedVendor.AddVendor(newOrder);
            List<Order> venderOrders = selectedVendor.Order;
            model.Add("orders", venderOrders);
            model.Add("vendor", selectedVendor);
            return View("Show", model);
        }
    }
}