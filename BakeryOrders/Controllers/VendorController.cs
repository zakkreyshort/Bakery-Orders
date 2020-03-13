using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendor/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendor")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Order;
            model.Add("vendor", selectedVendor);
            model.Add("order", vendorOrders);
            return View(model);
        }

        [HttpPost("/vendor/{id}/order")]
        public ActionResult Create(int vendorId, string name, string description, int price, int date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(name, description, price, date);
            selectedVendor.AddVendor(newOrder);
            List<Order> venderOrders = selectedVendor.Order;
            model.Add("order", venderOrders);
            model.Add("vendor", selectedVendor);
            return View("Show", model);
        }
    }
}