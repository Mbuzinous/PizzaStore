using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Drink
    {
        private int _menuNumber;
        private string _name;
        private int _price;

        public Drink(int MenuNumber, string Name, int Price)
        {
            _menuNumber = MenuNumber;
            _name = Name;
            _price = Price;
        }
        public override string ToString()
        {
            return $"Nr:{_menuNumber} {_name} {_price}kr";
        }
    }
}
