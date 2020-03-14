using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor>{};
        private static int _count = 0;
        public string Name { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }

        public Vendor(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _count;
            Orders = new List<Order>{};
            _count++;
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Vendor Find(int id)
        {
            int index = _instances.FindIndex(vendor => vendor.Id == id);
            return _instances[index];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}