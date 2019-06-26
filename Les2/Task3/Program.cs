using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;
            Random rnd = new Random();
            size = rnd.Next(2, 100);
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i != j && j > i)
                    {
                        arr[i, j] = 1;
                    }
                    if (i != j && j < i)
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
