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
        private int _price;
        public int _menuNumber;
        private static int _idCounter = 1;


        public Pizza(string name, string topping, int price)
        {
            _name = name;
            _topping = topping;
            _price = price;
            _menuNumber = _idCounter++;
        }
        
        public override string ToString()
        {
            return $"{_menuNumber}{"".PadRight(5)}{_name}\n{"".PadRight(6)}{_topping.PadRight(50)}{_price}\n";
        }
    }
}
