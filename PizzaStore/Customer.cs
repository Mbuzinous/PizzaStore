using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        private int _id;
        private string _name;

        private int _choice1;
        private int _choice2;
        private int _choice3;
        private string _choice4;

        public Customer(int Id)
        {
            _id = Id;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int Choice1
        {
            set { _choice1 = value; }
            get { return _choice1; }
        }

        public int Choice2
        {
            set { _choice2 = value; }
            get { return _choice2; }
        }

        public int Choice3
        {
            set { _choice3 = value; }
            get { return _choice3; }
        }

        public string Choice4
        {
            set { _choice4 = value; }
            get { return _choice4; }
        }

    }
}