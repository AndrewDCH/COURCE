using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polinominal;
namespace Task2
{
       
       
    
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial a = new Polynomial(5);
            Polynomial b = new Polynomial(3);
            string gt = a.OutPolynomial();
            Console.WriteLine(gt);
            string kt = b.OutPolynomial();
            Console.WriteLine(kt);
            a = a * b;
           
            string ut = a.OutPolynomial();
            Console.WriteLine(ut);
            Console.ReadKey();
        }
    }
}
