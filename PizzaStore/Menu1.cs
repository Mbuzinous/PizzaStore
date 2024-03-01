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

        //Drinks
        Drink drink1 = new Drink(6, "Cola", 20);
        Drink drink2 = new Drink(7, "Fanta", 20);
        Drink drink3 = new Drink(8, "Sprite", 20);

        //Toppings
        Topping topping1 = new Topping(9, "Chili", 10);
        Topping topping2 = new Topping(10, "Ananas", 10);
        Topping topping3 = new Topping(11, "¨Cheese", 15);
        Topping topping4 = new Topping(12, "Bacon", 15);
        Topping topping5 = new Topping(13, "Mozzarella", 20);
        Topping topping6 = new Topping(14, "Peperoni", 20);


        public override string ToString()
        {
            return $"Pizze Classiche\n{pizza1}\n{pizza2}\n{pizza3}\n{pizza4}\n{pizza5}\n\nDrinks\n{drink1}\n{drink2}\n{drink3}\n\nToppings\n{topping1}\n{topping2}\n{topping3}\n{topping4}\n{topping5}\n{topping6}";
        }


    }
    }