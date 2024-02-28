using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Pizza
    {
        int _menuNumber;
        string _name;
        string _topping;
        int _price;

        public Pizza(int MenuNumber, string Name, string Topping, int Price)
        {
            _menuNumber = MenuNumber;
            _name = Name;
            _topping = Topping;
            _price = Price;
        }
        public override string ToString()
        {
            return $"Nr:{_menuNumber}, Name {_name}, toppings {_topping}, Price {_price}kr";
        }

        /*public int MenuNumber
        {
            get { return _menuNumber; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Topping
        {
            get { return _topping; }
        }

        public int Price
        {
            get { return _price; }
        }*/
    }
}
