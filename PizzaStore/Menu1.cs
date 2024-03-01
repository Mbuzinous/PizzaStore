using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Menu1
    {
        //Pizza
        Pizza pizza1 = new Pizza(1, "Margherita", "Tomato & Cheese", 69);
        Pizza pizza2 = new Pizza(2, "Vesuvio", "Tomato, Cheese & Ham", 75);
        Pizza pizza3 = new Pizza(3, "Capricciosa", "Tomato, Cheese, Ham & Mushrooms", 80);
        Pizza pizza4 = new Pizza(4, "Calzone", "Tomato, Cheese, Ham & Mushrooms", 80);
        Pizza pizza5 = new Pizza(5, "Quattro Stagioni", "Tomato, Cheese, Ham, Mushrooms, Shrimp & Peppers", 85);

        //Toppings
        ExtraTopping extraTopping1 = new ExtraTopping(6, "Chili", 10);
        ExtraTopping extraTopping2 = new ExtraTopping(7, "Cheese", 15);
        ExtraTopping extraTopping3 = new ExtraTopping(8, "Mozzarella", 20);

        public override string ToString()
        {
            return $"Pizze Classiche\n{pizza1}\n{pizza2}\n{pizza3}\n{pizza4}\n{pizza5}\n\n{extraTopping1}\n{extraTopping2}\n{extraTopping3}";
        }


    }
    }