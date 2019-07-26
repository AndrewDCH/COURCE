using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    enum sort
    {
        increase, decrease
    };
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int lenght = rnd.Next(10, 100);
            int[] arr = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = rnd.Next(0, 20);
            }
            arr = BubleSort(arr, "increase");
            SortDetection(arr);
            Console.ReadKey();

        }
        public static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("  {0}", arr[i]);
            }
            Console.WriteLine();
        }
        public static int[] BubleSort(int[] arr,  sort a )
        {
          

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (a=="increace")
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            var swap = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swap;

                        }
                    }
                    if (a="decrease")
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            var swap = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swap;

                        }
                    }
                }

            }
            return arr;
        }
        public static void SortDetection(int[] arr, sort a )
        {
            
            int res = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (a=="increase")
                {
                    if (arr[i] > arr[i + 1])
                    {
                        res = 1;
                    }
                    else
                    {
                        res = 2;
                        break;
                    }
                }
                if (a=="decrease")
                {
                    if (arr[i] < arr[i + 1])
                    {
                        res = 1;
                    }
                    else
                    {
                        res = 2;
                        break;
                    }
                }
            }
            if (res == 2)
            {
                Console.WriteLine("Array is sorted");
            }
            else
            {
                Console.WriteLine("Array is unsorted");
            }
        }
    }
}
