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
            _instances.Add(Id);
            Id = _count;
            Orders = new List<Order>{};
            _count++;
        }
    }
}