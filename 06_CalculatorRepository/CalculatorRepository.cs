using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepository
{
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }

        public int SubstractTwoNumbers(int substractOne, int substractTwo)
        {
            int sumTwo = substractOne - substractTwo;
            return sumTwo;
        }

        public int DivideTwoNumbers(int divOne, int divTwo)
        {
            int sumThree = divOne / divTwo;
            return sumThree;
        }

        public int MultiplyTwoNumbers(int multOne, int multTwo)
        {
            int sumFour = multOne * multTwo;
            return sumFour;
        }
        
        public int RemainderOfTwoNumbers(int remainOne, int remainTwo)
        {
            int sumFive = remainOne % remainTwo;
            return sumFive;
        }

    }
}
