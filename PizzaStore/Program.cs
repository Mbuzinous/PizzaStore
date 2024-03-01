using System.Runtime.CompilerServices;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu1 menu1 = new Menu1();
            Customer customer1 = new Customer(1000);

            Console.WriteLine($"\nHello there welcome to Big Mama pizza, here is the menu of our authentic italian pizzas\n");
            Console.WriteLine(menu1.ToString());

            Console.WriteLine("\nWhich pizza would you like to have? (write number)\n");


            //Converts ReadLine from String to Int and saves it in choice3
           
            customer1.Choice1 = Convert.ToInt32(Console.ReadLine());

            if (customer1.Choice1 == 1)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice1} Margherita");
            }
            else if (customer1.Choice1 == 2)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice1} Vesuvio");
            }
            else if (customer1.Choice1 == 3)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice1} Capricciosa");
            }

        }
    }
}
