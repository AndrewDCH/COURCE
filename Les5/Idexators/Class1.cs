using System;

namespace Idexators
{
    public class ArrayIndex
    {
        private Random rnd = new Random();
        public int Lenght { get; private set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int[] array;
        public ArrayIndex(int lenght)
        {
            array = new int[lenght];
            Lenght = lenght;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Initilize()
        {
            array = new int[Lenght + Math.Abs( StartIndex)];
            
            for(int i = 0; i < Lenght; i++)
            {
                this[StartIndex + i] = rnd.Next(0, 100);
            }
            EndIndex = Lenght + StartIndex;
        }
        public void ShowArray()
        {
            for (int i = StartIndex; i < EndIndex; i++)
            {
                Console.WriteLine(i + "  " + this[i]);
            }
        }

    }
}
