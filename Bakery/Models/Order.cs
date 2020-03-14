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
        public int Id { get; }
        private static int _count = 0;

        private static List<Order> _orders = new List<Order> {};

        public Order(string name, string description, int price, int date)
        {
            Name = name;
            Description = description;
            Price = price;
            Date = date;
            _orders.Add(this);
            Id = _count;
            _count++;
        }

        public static List<Order> GetAll()
        {
            return _orders;
        }

        public static void ClearAll()
        {
            _orders.Clear();
        }

        public static Order Find(int id)
        {
            int index = _orders.FindIndex(order => order.Id == id);
            return _orders[index];
        } 
    }
}