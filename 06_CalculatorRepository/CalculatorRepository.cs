using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepository
{
    public class CalculatorRepository
    {
        public void AddTwoNumbers(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public void SubstractTwoNumbers(int substractOne, int substractTwo)
        {
            int sumTwo = substractOne - substractTwo;
            Console.WriteLine(sumTwo);
            Console.ReadKey();
        }

        public void DivideTwoNumbers(int divOne, int divTwo)
        {
            int sumThree = divOne / divTwo;
            Console.WriteLine(sumThree);
            Console.ReadKey();
            
        }

        public void MultiplyTwoNumbers(int multOne, int multTwo)
        {
            int sumFour = multOne * multTwo;
            Console.WriteLine(sumFour);
            Console.ReadKey();
        }
        
        public void RemainderOfTwoNumbers(int remainOne, int remainTwo)
        {
            int sumFive = remainOne % remainTwo;
            Console.WriteLine(sumFive);
            Console.ReadKey();
        }

    }
}
