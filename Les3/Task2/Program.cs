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
            int arithmeticSum = 0;
            double geometricSum =0;
            arithmeticSum = ArithmeticProgressionSum(2, 3, 5, arithmeticSum);
            Console.WriteLine("sum = {0}", arithmeticSum);
            

            
            geometricSum = GeometricProggressionSum(5, 0.5, 3, 2, geometricSum, 0, 0.0);

            Console.WriteLine("sum = {0}", geometricSum);
            Console.ReadKey();
        }
        public static int ArithmeticProgressionSum(int firstMemberOfProgression, int stepOfProgression, int n, int sum) //first task
        {
            sum += firstMemberOfProgression + stepOfProgression;
            n--;
            if (n != 0)
            {
                sum = ArithmeticProgressionSum(sum, stepOfProgression, n, sum);
            }
            return sum;
        }
        public static double GeometricProggressionSum(double firstMemberOfProgression, double alim, int n, double stepOfProgression, double sum, int k, double prevEl)//second task 
        {
            if (n == k)
            {
                if (prevEl > alim)
                {
                    return sum;
                }
                else
                {
                    Console.WriteLine("An>alim");
                    return 0;
                }
            }
            else
            {
                sum += firstMemberOfProgression / stepOfProgression;
                prevEl = firstMemberOfProgression / stepOfProgression;
                k++;
                GeometricProggressionSum(sum, alim, n, stepOfProgression, sum, k, prevEl);
            }
            return sum;
        }

    }
}
