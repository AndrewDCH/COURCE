using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ArithmeticProgression
    {
        private int _firstMemberOfProgress, _stepOfProgression;
        public int FirstMember
        {
            get
            {
                return this._firstMemberOfProgress;
            }
            set
            {
                _firstMemberOfProgress = value;
            }
        }
        public int StepOfProgression
        {
            get
            {
                return this._stepOfProgression;
            }
            set
            {
                _stepOfProgression = value;
            }
        }
        public ArithmeticProgression()
        {
            _firstMemberOfProgress = 0;
            _stepOfProgression = 0;
        }
        public ArithmeticProgression(int firstMemberOfProgression)
        {
            _firstMemberOfProgress = firstMemberOfProgression;
        }
        public ArithmeticProgression(int firstMemberOfProgression, int stepOfProgression)
        {
            _firstMemberOfProgress = firstMemberOfProgression;
            _stepOfProgression = stepOfProgression;
        }
        public double AvgOfSumOfProgression(int numberOfMembers)
        {
            int sum=0, k=_firstMemberOfProgress;
            for(int i=0;i<numberOfMembers;i++){
                sum += k;
                k += _stepOfProgression;
            }
            return sum / numberOfMembers;
        }
        public int SumOfNMembers(int nMember)
        {
            int sum = 0 ,k=_firstMemberOfProgress;
            for(int i = 0; i < nMember; i ++)
            {

                sum += k;
                k += _stepOfProgression;
            }
            return sum;
        }

    };
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression a = new ArithmeticProgression(2, 3);
            Console.WriteLine(a.SumOfNMembers(5));
            Console.ReadKey();
        }

    }
}
