using _06_CalculatorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepositoryConsole
{
    public class ProgramUI
    {
        public void GetNumbersAndPrint()
        {
            Console.WriteLine("Please enter a number:");
            int numOne = int.Parse(Console.ReadLine());
            //int numOne = int.Parse(userInput1)

            Console.WriteLine("Please enter a number.");
            int numTwo = int.Parse(Console.ReadLine());

            CalculatorRepository calcRepo = new CalculatorRepository();

            int result = calcRepo.AddTwoNumbers(numOne, numTwo);

            Console.WriteLine("The results are in... the All-Knowing Entity says the answer is " + result);
            Console.ReadKey();


        }
        
    }
}
