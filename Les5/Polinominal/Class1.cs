using System;

namespace Polinominal
{
    public class Polynomial
    {
        private int _polPow = 2;

        Random rnd = new Random();

        public int[,] polynomialArray;//в первом ряду матрицы храняться коефициенты членов, во втором степени членов 
        public int PolPow
        {
            set
            {
                _polPow = value;
            }
            get
            {
                return _polPow;

            }

        }
        public Polynomial(int polPow)
        {
            _polPow = polPow;
            polynomialArray = new int[2, polPow + 1];
            for (int i = 0; i < polPow + 1; i++)
            {
                polynomialArray[0, i] = rnd.Next(-10, 10);
                polynomialArray[1, i] = _polPow - i;
            }
        }
        public string OutPolynomial()
        {
            string polynomOut = default(string);
            if (_polPow == 0)
            {
                polynomOut = Convert.ToString(polynomialArray[0, 0]);
            }
            if (_polPow == 1)
            {
                if (polynomialArray[0, 1] >= 0)
                {
                    polynomOut = Convert.ToString(polynomialArray[0, 0]) + "x +" + Convert.ToString(polynomialArray[0, 1]);

                }
                else
                {
                    polynomOut = Convert.ToString(polynomialArray[0, 0]) + "x " + Convert.ToString(polynomialArray[0, 1]);
                }
            }
            else
            {
                for (int i = 0; i < _polPow + 1; i++)
                {
                    if (polynomialArray[0, i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (_polPow - i >= 2)
                        {
                            if (polynomialArray[0, i] >= 0)
                            {
                                polynomOut += "+ " + Convert.ToString(polynomialArray[0, i]) + "x^" + Convert.ToString(polynomialArray[1, i]) + " ";

                            }
                            else
                            {
                                polynomOut += " " + Convert.ToString(polynomialArray[0, i]) + "x^" + Convert.ToString(polynomialArray[1, i]) + " ";

                            }
                        }
                        if (_polPow - i == 1)
                        {
                            if (polynomialArray[0, i] >= 0)
                            {
                                polynomOut += "+ " + Convert.ToString(polynomialArray[0, i]) + "x";

                            }
                            else
                            {
                                polynomOut += " " + Convert.ToString(polynomialArray[0, i]) + "x";
                            }
                        }
                        if (_polPow - i == 0)
                        {
                            if (polynomialArray[0, i] >= 0)
                            {
                                polynomOut += "+ " + Convert.ToString(polynomialArray[0, i]);

                            }
                            else
                            {
                                polynomOut += " " + Convert.ToString(polynomialArray[0, i]);
                            }
                        }
                    }
                }
            }
            return polynomOut;
        }
        public int Lenght
        {
            get
            {
                return this._polPow;

            }
            private set
            {
                _polPow = value;
            }
        }
        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            if (a.Lenght + 1 >= b.Lenght + 1)
            {
                for (int i = 0; i < b.Lenght + 1; i++)
                {
                    for (int j = 0; j < a.Lenght + 1; j++)
                    {
                        if (b.polynomialArray[1, i] == a.polynomialArray[1, j])
                        {
                            a.polynomialArray[0, j] = a.polynomialArray[0, j] + b.polynomialArray[0, i];
                        }

                    }
                }
                return a;
            }
            if (a.Lenght + 1 < b.Lenght + 1)
            {
                for (int i = 0; i < a.Lenght + 1; i++)
                {
                    for (int j = 0; j < b.Lenght + 1; j++)
                    {
                        if (a.polynomialArray[1, i] == b.polynomialArray[1, j])
                        {
                            b.polynomialArray[0, j] = b.polynomialArray[0, j] + a.polynomialArray[0, i];
                        }

                    }
                }



                return b;
            }
            return null;
        }
        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            if (a.Lenght + 1 >= b.Lenght + 1)
            {
                for (int i = 0; i < b.Lenght + 1; i++)
                {
                    for (int j = 0; j < a.Lenght + 1; j++)
                    {
                        if (b.polynomialArray[1, i] == a.polynomialArray[1, j])
                        {
                            a.polynomialArray[0, j] = a.polynomialArray[0, j] - b.polynomialArray[0, i];
                        }

                    }
                }
                return a;
            }
            if (a.Lenght + 1 < b.Lenght + 1)
            {
                for (int i = 0; i < a.Lenght + 1; i++)
                {
                    for (int j = 0; j < b.Lenght + 1; j++)
                    {
                        if (a.polynomialArray[1, i] == b.polynomialArray[1, j])
                        {
                            b.polynomialArray[0, j] = b.polynomialArray[0, j] - a.polynomialArray[0, i];
                        }

                    }
                }



                return b;
            }
            return null;
        }
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            int lenght = a.Lenght + b.Lenght + 1;
            int[,] arr = new int[2, a.Lenght + b.Lenght];
            for (int i = 0; i < lenght - 1; i++)
            {
                arr[1, i] = lenght - i;
                arr[0, i] = 0;
            }
            if (a.polynomialArray.Length >= b.polynomialArray.Length)
            {
                for (int i = 0; i < b.Lenght; i++)
                {
                    for (int j = 0; j < a.Lenght; j++)
                    {
                        arr[0, i + j] = b.polynomialArray[0, i] * a.polynomialArray[0, j];
                    }
                }
                a.polynomialArray = arr;
                return a;
            }
            if (a.polynomialArray.Length < b.polynomialArray.Length)
            {
                for (int i = 0; i < a.Lenght; i++)
                {
                    for (int j = 0; j < b.Lenght; j++)
                    {
                        arr[0, i + j] = a.polynomialArray[0, i] * b.polynomialArray[0, j];
                    }
                }
                b.polynomialArray = arr;
                return b;
            }
            return null;
        }
    }
}
