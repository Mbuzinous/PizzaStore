using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {
        private static int _idCounter = 5000;
        public int _id;
        public DateTime _date;

        private double _totalPrice;
        private Pizza _pizza1;
        private Pizza _pizza2;
        private Pizza _pizza3;
        public Customer Customer { get; set; }




        public Order(Customer customer, Pizza pizza1, Pizza pizza2, Pizza pizza3)
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            Customer = customer;
            _pizza1 = pizza1;
            _pizza2 = pizza2;
            _pizza3 = pizza3;

        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            totalPrice = totalPrice + _pizza1.Price;
            totalPrice = totalPrice + _pizza2.Price;
            totalPrice = totalPrice + _pizza3.Price;

            double taxRate = 0.25;
            totalPrice = totalPrice * (1 + taxRate);

            double deliveryCost = 40;
            totalPrice = totalPrice + deliveryCost;

            _totalPrice = totalPrice;

            return _totalPrice;
        }

        public override string ToString()
        {
            return $"OrderID: {_id}{"".PadRight(10)}Date: {_date.ToString("dd-MM-yy : Clock : HH:mm:ss:ff")}\n{Customer} has ordered:\n{_pizza1.Name.PadRight(20)}{_pizza1.Price}KR\n{_pizza2.Name.PadRight(20)}{_pizza2.Price}KR\n{_pizza3.Name.PadRight(20)}{_pizza3.Price}KR\nTotal Price: {CalculateTotalPrice()}\n";
        }

    }
}