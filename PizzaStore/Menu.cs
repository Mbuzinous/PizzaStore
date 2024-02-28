using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Menu
    {
        Pizza pizza1 = new Pizza(1, "Peperoni pizza", "tomat, ost, peperoni", 90);
        public override string ToString()
        {
            return $"{pizza1}";
        }
    }
}
