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
        private string _address;
        private string _choice1;
        private string _choice2;
        private int _choice3int;
        private string _choice3string;
        private string _choice3string2;
        private string _choice4;
        private int _choice5;

        public Customer()
        {
            string Id;

        }

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        public string Choice1
        {
            set { _choice1 = value; }
            get { return _choice1; }
        }

        public string Choice2
        {
            set { _choice2 = value; }
            get { return _choice2; }
        }

        public int Choice3int
        {
            set { _choice3int = value; }
            get { return _choice3int; }
        }

        public string Choice3string
        {
            set { _choice3string = value; }
            get { return _choice3string; }
        }

        public string Choice3string2
        {
            set { _choice3string2 = value; }
            get { return _choice3string2; }
        }

        public string Choice4
        {
            set { _choice4 = value; }
            get { return _choice4; }
        }

        public int Choice5
        {
            set { _choice5 = value; }
            get { return _choice5; }
        }

    }
}