using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les7
{
    class Program
    {
        interface IShape
        {
            string GetName();
            double GetArea();
        }
        class Shape:IShape
        {
            public virtual string GetName()
            {
                return "Its Shape";
            }
            public virtual double GetArea()
            {
                Random rnd = new Random();
                double area = rnd.Next(0,10)+rnd.NextDouble();
                return area;
            }
        }
        class Triangle : Shape
        {
            public override string GetName()
            {
                return "Its Triangle";
            }
            public  double GetArea(int sideA, int sideB, int sideC)
            {
                if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                {
                    return 0.0;
                }
                else
                {
                    double p = (sideA + sideB + sideC) / 2;
                    double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                    return area;
                }
                
               
                
            }
        }
        class Circle : Shape 
        {
            public override string GetName()
            {
                return "Its circle";
            }
            public double GetArea(double r)
            {
                return Math.PI * r * r;
            }
        }
        class Rectangle : Shape
        {
            public override string GetName()
            {
                return "Its rectangle";
            }
            public double GetArea(int sideA, int sideB)
            {
                return sideA * sideB;
            }
        }
        class IsoscelesTriangle: Triangle
        {
            public override string GetName()
            {
                return "Its isosceles triangle";
            }

        }
        class Square : Rectangle
        {
            public override string GetName()
            {
                return "Its square";
            }
            public double GetArea(double sideA)
            {
                return sideA * sideA;
            }
        }
        static void Main(string[] args)
        {
            Triangle a = new Triangle();
            string name = a.GetName();
            Console.WriteLine(name);
        }
    }
}
