using System.Runtime.CompilerServices;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store BigMama = new Store();
            BigMama.Start();
            Console.WriteLine(BigMama.ToString());
            Console.ReadKey();
        }
    }
}
