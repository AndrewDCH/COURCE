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
            int firstElOfDiapason, secondElOfDiapason;
            Random rnd = new Random();
            firstElOfDiapason = rnd.Next(0, 1000);
            secondElOfDiapason = rnd.Next(0, 1000);
            Console.WriteLine("Avg = {0}", Avg(firstElOfDiapason, secondElOfDiapason));
            int n1;
            n1 = rnd.Next(0, 1000);
            Console.WriteLine("Sum1 = {0}", Sum1(n1));
            int firstElement, secondElement;
            firstElement = rnd.Next(0, 1000);
            secondElement = rnd.Next(0, 1000);
            Console.WriteLine("Sum2 = {0}", Sum2(firstElement, secondElement));
            Console.ReadKey();
        }
        public static double Avg(int value1, int value2)//first task
        {
            if (value1 > value2)
            {
                int change;
                change = value2;
                value2 = value1;
                value1 = change;
            }
            int j = 0;
            double sum = 0;
            for (int i = value1; i <= value2; i++)
            {
                sum += i;
                j++;
            }
            sum = sum / j;
            return sum;

        }
        public static int Sum1(int value)//second task
        {
            int sum = 0;
            for (int i = 0; i <= value; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        public static int Sum2(int value1, int value2)//third task
        {
            if (value1 > value2)
            {
                int change;
                change = value2;
                value2 = value1;
                value1 = change;
            }
            int sum = 0;
            for (int i = value1; i <= value2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
