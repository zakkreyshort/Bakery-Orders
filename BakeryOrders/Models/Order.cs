using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Date { get; set ;}
        // maybe add payment verification?
        public int Id { get; }
        private static int _count = 0;

        private static List<Order> _instances = new List<Order> {};

        public Order(string name, string description, int price, int date)
        {
            Name = name;
            Description = description;
            Price = price;
            Date = date;
            _instances.Add(this);
            Id = _count;
            _count++;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int id)
        {
            int inex = _instances.FindIndex(order => order.Id == id);
            return _instances[index];
        }
    }
}