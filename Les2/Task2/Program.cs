using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int lenght = rnd.Next(10, 20);
            int[] arr = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = rnd.Next(0, 10);
            }
            Console.Write("Start array = ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(" {0}", arr[i]);
            }

            Console.WriteLine();
            arr = ArrayChange(arr, lenght);
            int lenghtBeetwenMax;

            lenghtBeetwenMax = ArrayMaxElLenght(arr);
            Console.Write("Changed array = ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(" {0}", arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Lenght between max = {0}", lenghtBeetwenMax);
            Console.ReadKey();
        }
        public static int[] ArrayChange(int[] arr, int lenght)//first task
        {
            if (lenght % 2 == 0)
            {
                for (int i = 0; i < lenght / 2; i++)
                {
                    int change;
                    change = arr[i];
                    arr[i] = arr[lenght - i - 1];
                    arr[lenght - i - 1] = change;
                }
            }
            else
            {
                for (int i = 0; i < lenght / 2 - 0.5; i++)
                {
                    int change;
                    change = arr[i];
                    arr[i] = arr[lenght - i - 1];
                    arr[lenght - i - 1] = change;
                }
            }
            return arr;
        }
        public static int ArrayMaxElLenght(int[] arr)//second task
        {
            int firstIndex = 0, secondIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr.Max())
                {
                    firstIndex = i;
                    break;
                }
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == arr.Max())
                {
                    secondIndex = i;
                    break;
                }
            }
            if (firstIndex == secondIndex)
            {
                return 0;
            }
            return secondIndex - firstIndex-1;
        }
    }
}
