using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int ageAsTypeInt = int.Parse(age);

        }
    }
}
