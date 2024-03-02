using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzaStore
{
    internal class Customer
    {
        private string _name;
        public int _id;
        private static int _idCounter = 100;

        public Customer(string name)
        {
            _name = name;
            _id = _idCounter++;
        }

        public override string ToString()
        {
            return $"CustomerID: {_id}\nName: {_name}\n";
        }
    }
}