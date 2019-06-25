using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolPrj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("You are {0} {1}", name, surname);
            Console.WriteLine("It's project ConsolPrj2");
            Console.ReadKey();
        }
    }
}
