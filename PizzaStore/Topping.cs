using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Topping
    {
        private int _menuNumber;
        private string _name;
        private int _price;

        public Topping(int MenuNumber, string Name, int Price)
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
