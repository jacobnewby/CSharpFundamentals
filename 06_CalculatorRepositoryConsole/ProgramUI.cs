using _06_CalculatorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepositoryConsole
{
    internal class ProgramUI
    {
        CalculatorRepository _mathRepo = new CalculatorRepository();

        public ProgramUI()
        {
        }

        public void RunMath()
        {
            RunMenu();
        }



        private void RunMenu()
        {

            Console.WriteLine("Enter option number: \n" +
                "1. Add two numbers\n" +
                "2. Substract two numbers\n" +
                "3. Divide two numbers\n" +
                "4. Multiply two numbers\n" +
                "5. Find the remainder of two numbers\n" +
                "6. Exit\n" +
                "");

            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            switch (userNumber)
            {
                case 1:
                    AddTwoNumbersUI();
                    break;
                case 2:
                    SubstractTwoNumbersUI();
                    break;
                case 3:
                    DivideTwoNumbersUI();
                    break;
                case 4:
                    MultiplyTwoNumbersUI();
                    break;
                case 5:
                    RemainderTwoNumbersUI();
                    break;
                case 6:
                    break;

            }
        }

        public void AddTwoNumbersUI()
        {
            Console.WriteLine("Enter the first number: ");
            string numberOneAsString = Console.ReadLine();
            int numberOne = int.Parse(numberOneAsString);

            Console.WriteLine("Enter the second number: ");
            string numberTwoAsString = Console.ReadLine();
            int numberTwo = int.Parse(numberTwoAsString);

            _mathRepo.AddTwoNumbers(numberOne, numberTwo);

        }

        public void SubstractTwoNumbersUI()
        {
            Console.WriteLine("Enter the first number: ");
            string numberOneAsString = Console.ReadLine();
            int substractOne = int.Parse(numberOneAsString);

            Console.WriteLine("Enter the second number: ");
            string numberTwoAsString = Console.ReadLine();
            int substractTwo = int.Parse(numberTwoAsString);

            _mathRepo.SubstractTwoNumbers(substractOne, substractTwo);
        }

        public void DivideTwoNumbersUI()
        {
            Console.WriteLine("Enter the first number: ");
            string numberOneAsString = Console.ReadLine();
            int divOne = int.Parse(numberOneAsString);

            Console.WriteLine("Enter the second number: ");
            string numberTwoAsString = Console.ReadLine();
            int divTwo = int.Parse(numberTwoAsString);

            _mathRepo.DivideTwoNumbers(divOne, divTwo);
        }

        public void MultiplyTwoNumbersUI()
        {
            Console.WriteLine("Enter the first number: ");
            string numberOneAsString = Console.ReadLine();
            int multOne = int.Parse(numberOneAsString);

            Console.WriteLine("Enter the second number: ");
            string numberTwoAsString = Console.ReadLine();
            int multTwo = int.Parse(numberTwoAsString);

            _mathRepo.MultiplyTwoNumbers(multOne, multTwo);
        }

        public void RemainderTwoNumbersUI()
        {
            Console.WriteLine("Enter the first number: ");
            string numberOneAsString = Console.ReadLine();
            int remainOne = int.Parse(numberOneAsString);

            Console.WriteLine("Enter the second number: ");
            string numberTwoAsString = Console.ReadLine();
            int remainTwo = int.Parse(numberTwoAsString);

            _mathRepo.RemainderOfTwoNumbers(remainOne, remainTwo);
        }
    }
}
