using System;

namespace Idexators
{
   public class ArrValue
    {
        public int val;
    }
    public class ArrayIndex
    {
        private Random _rnd = new Random();

        public int startIndex, lastIndex;
        public ArrValue[] array;

        public ArrayIndex(int lenght, int startIndex)
        {
            array = new ArrValue[lenght + startIndex];
        }

        public ArrValue this[int index]
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
    }
}
