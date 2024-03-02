using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Store
    { 
        Pizza _pizza1, _pizza2, _pizza3;
        Customer _customer1, _customer2, _customer3;
        Order _order1, _order2, _order3;

        private int _totalPrice;


        public Store()
        {

        }

        public void Start()
        {
            _pizza1 = new Pizza("Margherita", "Tomato & Cheese", 69);
            _pizza2 = new Pizza("Vesuvio", "Tomato, Cheese & Ham", 75);
            _pizza3 = new Pizza("Capricciosa", "Tomato, Cheese, Ham & Mushrooms", 80);

            _customer1 = new Customer("Kevin");
            _customer2 = new Customer("Ana");
            _customer3 = new Customer("Max");

            _order1 = new Order(_customer1, _pizza1);

        }

        public override string ToString()
        {
            return $"--------------- Menu ---------------\n{"Nr".PadRight(6)}Pizza\n{_pizza1}\n{_pizza2}\n{_pizza3}\n--------------- Customers ---------------\n{_customer1}\n{_customer2}\n{_customer3}\n--------------- Orders ---------------\n{_order1}\n{_order2}\n{_order3}";
        }
    }
}
