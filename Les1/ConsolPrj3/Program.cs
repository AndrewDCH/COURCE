using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arithmetic;

namespace ConsolPrj3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 6;
            Console.WriteLine(Arithmitic.Add(a, b));
            Console.WriteLine(Arithmitic.Subtract(a, b));
            Console.WriteLine(Arithmitic.Multiply(a, b));
            Console.WriteLine(Arithmitic.Divide(a, b));
            Console.ReadKey();
        }
    }
}
