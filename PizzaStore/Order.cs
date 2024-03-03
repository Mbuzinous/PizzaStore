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
        private Customer _customer;
        private Pizza _pizzaChoice1;
        private Pizza _pizzaChoice2;
        private Pizza _pizzaChoice3;

        private int _id;
        private static int _idCounter = 5000;
        private DateTime _date;

        private double _tax = 1.25;
        private double _deliveryCost = 40;
        private double _totalPrice;

        public Order(Customer customer, Pizza pizzaChoice1, Pizza pizzaChoice2, Pizza pizzaChoice3)
        {
            _customer = customer;
            _pizzaChoice1 = pizzaChoice1;
            _pizzaChoice2 = pizzaChoice2;
            _pizzaChoice3 = pizzaChoice3;
            _id = _idCounter;
            _idCounter++;
            _date = DateTime.Now;
        }

        public double CalculateTotalPrice()
        {
            _totalPrice += (_pizzaChoice1.Price + _pizzaChoice2.Price + _pizzaChoice3.Price) * _tax;
            //Here i assign the first customer to have free delivery
            if (_customer.Id == 100)
            {
                return _totalPrice;
            }
            else
            {
                _totalPrice += _deliveryCost;
                return _totalPrice;
            }
        }

        public override string ToString()
        {
            return $"{_customer} has ordered\n{_pizzaChoice1.Name.PadRight(20)}{_pizzaChoice1.Price}KR\n{_pizzaChoice2.Name.PadRight(20)}{_pizzaChoice2.Price}KR\n{_pizzaChoice3.Name.PadRight(20)}{_pizzaChoice3.Price}KR\nTotal Price: {CalculateTotalPrice()}\nOrderID: {_id}{"".PadRight(10)}Date: {_date.ToString("dd-MM-yy : Clock : HH:mm:ss:ff")}\n";
        }

    }
}