using System;
using _06_CalculatorRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_CalculatorRepositoryTests
{
    [TestClass]
    public class CalculatoryRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Please enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.AddTwoNumbers(a, b);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}
