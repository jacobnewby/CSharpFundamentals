using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 13;

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < studentCount; i++)
            {
                studentCount--;
                Console.WriteLine(i);
                Console.WriteLine(studentCount);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int number = 5;
            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            List<string> students = new List<string>();

            students.Add("Regan");
            students.Add("Paul");
            students.Add("Ben");
            students.Add("Aaron");
            students.Add("Erick");
            
            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            string mountainName = "Mauna Kea";
            foreach(char letters in mountainName)
            {
                if (letters == 'a')
                {
                    Console.WriteLine(letters);
                }
            }
        }
    }
}
