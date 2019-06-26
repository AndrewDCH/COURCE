using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Square
    {
        private double _sideOfSquare, _perimeter, _square;
        public Square()
        {
            _sideOfSquare = 0;
        }
        public Square(double sideOfSquare)
        {
            this._sideOfSquare = sideOfSquare;
        }
        public double PerimeterCalculation()
        {
            return 4 * _sideOfSquare;
        }
        public double SquareCalculation()
        {
            return _sideOfSquare * _sideOfSquare;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Square k = new Square(3);
            Console.WriteLine("square={0}", k.SquareCalculation());
            Console.ReadKey();
        }
    }
}
