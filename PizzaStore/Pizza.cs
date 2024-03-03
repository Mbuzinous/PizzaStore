using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Pizza
    {
        private string _name;
        private string _topping;
        private double _price;
        private int _menuNumber;
        private static int _idCounter = 1;

        public Pizza(string name, string topping, int price)
        {
            _name = name;
            _topping = topping;
            _price = price;
            _menuNumber = _idCounter;
            _idCounter++;
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Topping
        {
            get { return _topping; }
            private set { _topping = value; }
        }
        public double Price
        {
            get { return _price; }
            private set { _price = value; }
        }
        public int MenuNumber
        {
            get { return _menuNumber; }
            private set { _menuNumber = value; }
        }

        public override string ToString()
        {
            return $"{MenuNumber}{"".PadRight(5)}{Name}\n{"".PadRight(6)}{Topping.PadRight(50)}{Price}\n";
        }
    }
}
