using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
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
            arr = BubleSort(arr);
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
        public static int[] BubleSort(int[] arr)
        {
            int ind;
            Console.WriteLine("Enter 1 if you want ascending sort or enter 2 if you want descenting sort");
            ind = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (ind == 1)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            var swap = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swap;

                        }
                    }
                    if (ind == 2)
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
        public static void SortDetection(int[] arr)
        {
            Console.WriteLine("Array should be sorted as ascend or descend array(Enter 1-ascend array, 2-descend array)");
            int ind = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (ind == 1)
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
                if (ind == 2)
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
