using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace les6
{
    
    class Matrix
    {
        private int _height, _width;
        Random rnd = new Random();
        public int[,] matrix;
        public Matrix(int a,  int b)
        {
            matrix = new int[a, b];
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            _height = a;
            _width = b;
        }
        public int Height
        {
            get
            {
                return _height;
            }
            private set
            {
                _height = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            private set
            {
                _width = value;
            }
        }
        public int[,] SumMatrix(Matrix a, Matrix b)
        {
            if(a.Height!=b.Height || a.Width != b.Width)
            {
                throw new Exception("Cant sum matrix");
            }
            else
            { 
               for(int i = 0; i < a.Height; i++)
               {
                    for(int j = 0; j < a.Width; j++)
                    {
                       a.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                    }
               }
            }
            return a.matrix;

        }
        public int[,] SubMatrix(Matrix a, Matrix b)
        {
            if (a.Height != b.Height || a.Width != b.Width)
            {
                throw new Exception("Cant sutract matrix");
            }
            else
            {
                for (int i = 0; i < a.Height; i++)
                {
                    for (int j = 0; j < a.Width; j++)
                    {
                        a.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
            }
               
            return a.matrix;

        }
        public int[,] MulMatrix(Matrix a, Matrix b)
        {
            int[,] resMatrix = new int[a.Height, b.Width];
            if (a.Height != b.Width)
            {
                throw new Exception("Cant multiply matrix");
            }
            else
            { 
                for(int i = 0; i < a.Height; i++)
                {
                    for(int j = 0; j < b.Width; j++)
                    {
                        for(int k = 0; k < b.Height; k++)
                        {
                            resMatrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
            }
            
            return resMatrix;
        }
        public void OutArray(Matrix a)
        {
            for(int i = 0; i < a.Height; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < a.Width; j++)
                {
                    Console.Write("  {0}", a.matrix[i, j]);
                }
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(4, 6);
            a.OutArray(a);
            Thread.Sleep(10);
            
            Matrix b = new Matrix(6, 4);
            b.OutArray(b);
            try
            {
                a.matrix = a.SumMatrix(a, b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);   
            }
            try
            {
                a.matrix = a.MulMatrix(a, b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}
