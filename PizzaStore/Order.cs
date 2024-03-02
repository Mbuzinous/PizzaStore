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

        private int _totalPrice;
        private Pizza _pizza1;
        public Customer Customer1 { get; set; }




        public Order(Customer customer1, Pizza pizza1)
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            Customer1 = customer1;
            _pizza1 = pizza1;
            
        }

        public override string ToString()
        {
            return $"OrderID: {_id}{"".PadRight(10)}\nDate: {_date.ToString("dd-MM-yy : Clock : HH:mm:ss:ff")}\n";
        }

    }
}