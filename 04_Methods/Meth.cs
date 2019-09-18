using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class Meth
    {
        [TestMethod]
        public void Methods()
        {
            // + = - / * %

            int sum = 2 + 2;
            int substraction = 2 - 2;
            int multiply = 2 * 2;
            int divide = 2 / 2;
            int remainder = 2 % 2;

            int expected = 8;
            int actual = AddTwoNumbers(sum, multiply);
            Assert.AreEqual(expected, actual);

            int expectedTwo = -1;
            int actualTwo = SubstractTwoNumbers(divide, remainder);
            Assert.AreEqual(expectedTwo, actualTwo);

            int expectedThree = 4;
            int actualThree = MultiplyTwoNumbers(multiply, divide);
            Assert.AreEqual(expectedThree, actualThree);

            int expectedFour = 4;
            int actualFour = DivideTwoNumbers(sum, divide);
            Assert.AreEqual(expectedFour, actualFour);

            int expectedFive = 0;
            int actualFive = RemainderTwoNumbers(multiply, sum);
            Assert.AreEqual(expectedFive, actualFive);
        }

        //1 access modifier //2 return type //3 method name //4 parameters
       
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int SubstractTwoNumbers(int numOne, int numTwo)
        {
            int substract = numTwo - numOne;
            return substract;
        }

        public int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int multiply = numOne * numTwo;
            return multiply;
        }

        public int DivideTwoNumbers(int numOne, int numTwo)
        {
            int divide = numOne / numTwo;
            return divide;
        }

        public int RemainderTwoNumbers(int numOne, int numTwo)
        {
            int remainder = numOne % numTwo;
            return remainder;
        }
    }
}
