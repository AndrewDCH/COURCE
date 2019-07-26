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
            int arrayLenght = 5, startIndex = 4;
            ArrayIndex array = new ArrayIndex(arrayLenght, startIndex);
            array = ArrayInitialization(array);
            Console.WriteLine("{0}", array.array[5]);
            Console.ReadKey();
        }
        public static ArrayIndex ArrayInitialization(ArrayIndex array)
        {
            Random rnd = new Random();
            Console.WriteLine("Enter start index ");
            array.startIndex = Convert.ToInt32(Console.ReadLine());
            array.lastIndex = array.startIndex + 5;
            for(int i = array.startIndex; i < 5 + array.startIndex; i++)
            {
                array.array[i] = new ArrValue { val = rnd.Next() };
            }
            return array;
        }
    }

}
