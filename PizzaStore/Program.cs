using System.Runtime.CompilerServices;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu1 menu1 = new Menu1();
            Customer customer1 = new Customer();

            //Asks for your name and saves it under the object customer1 in the variable _name
            Console.WriteLine("Hello there! Welcome to Big Mama Pizza, what's your name?\n");
            customer1.Name = Console.ReadLine();

            Console.WriteLine($"\nNice to meet you {customer1.Name}, here is the menu of our brand new Italian Classics\n");
            Console.WriteLine(menu1.ToString());

            Console.WriteLine("\nWhich pizza would you like to have? (write number)\n");
            //Converts ReadLine from String to Int and saves it in choice3
            customer1.Choice3int = Convert.ToInt32(Console.ReadLine());

            if (customer1.Choice3int == 1)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice3int} Margherita");
            }
            else if (customer1.Choice3int == 2)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice3int} Vesuvio");
                customer1.Choice3string = Convert.ToString(customer1.Choice3int);
                customer1.Choice3string2 = $"number {customer1.Choice3string} Vesuvio";
            }
            else if (customer1.Choice3int == 3)
            {
                Console.WriteLine($"You have chosen a number {customer1.Choice3int} Capricciosa");
                customer1.Choice3string = Convert.ToString(customer1.Choice3int);
                customer1.Choice3string2 = $"number {customer1.Choice3string} Capricciosa";
            }


            Console.WriteLine("Would you like to have a drink?");
            customer1.Choice4 = Console.ReadLine();
            if (customer1.Choice4 == "yes")
            {
                Console.WriteLine("Which drink would you like to have?");

                customer1.Choice5 = Convert.ToInt32(Console.ReadLine());

                if (customer1.Choice5 == 6)
                {
                    Console.WriteLine($"You have chosen a number {customer1.Choice5} Cola");
                }
                else if (customer1.Choice5 == 7)
                {
                    Console.WriteLine($"You have chosen a number {customer1.Choice5} Fanta");
                }
                else if (customer1.Choice5 == 8)
                {
                    Console.WriteLine($"You have chosen a number {customer1.Choice5} Sprite");
                }
            }

            if (customer1.Choice3int == 1)
            {
                Convert.ToString(customer1.Choice3int);
                customer1.Choice3string2 = $"number {customer1.Choice3int} Margherita";
                Console.WriteLine($"and a {customer1.Choice3string2} would you like to proceed to checkout?");
            }
            else if (customer1.Choice3int == 2)
            {
                Convert.ToString(customer1.Choice3int);
                customer1.Choice3string2 = $"number {customer1.Choice3int} Vesuvio";
                Console.WriteLine($"and a {customer1.Choice3string2} would you like to proceed to checkout?");
            }
            else if (customer1.Choice3int == 3)
            {
                Convert.ToString(customer1.Choice3int);
                customer1.Choice3string2 = $"number {customer1.Choice3int} Capricciosa";
                Console.WriteLine($"and a {customer1.Choice3string2} would you like to proceed to checkout?");
            }

        }
    }
}
