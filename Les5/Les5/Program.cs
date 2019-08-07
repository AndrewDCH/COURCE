using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idexators;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayIndex a = new ArrayIndex(6);
            a.StartIndex = -2;
            a.Initilize();
            a.ShowArray();
            Console.ReadKey();
        }
    }

}
