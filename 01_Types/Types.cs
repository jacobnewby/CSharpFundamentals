using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            char character = '?';

            byte g = 255; //0-255
            sbyte h = -128; //-128-127


            short a = -32768;
            short b = 32767;

            int c = -2147483648;
            int d = 2147483647;
            Int16 l = 32000;
            Int32 m = 2147483547;
            Int64 n = -9223372036854775808;

            long e = -9223372036854775808;
            long f = 9223372036854775807;

            float i = 1.04523f;
            double j = 1.72342342124d;
            decimal k = 1.234912312349m;



        }
        [TestMethod]
        public void Operators()
        {
            // + - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            int substraction = numberTwo - numberOne;
            float div = numberTwo / numberOne;
            int module = numberTwo % numberOne;
            int mult = numberTwo * numberOne;

            Console.WriteLine(sum);
            Console.WriteLine(substraction);
            Console.WriteLine(div);
            Console.WriteLine(module);
            Console.WriteLine(mult);
        }


        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Jacob";
            string lastName = "Newby";

            // Concatanation
            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            // Composite Formatting
            string composite = string.Format("Hello my name is {0} {1}", firstName, lastName);
            Console.WriteLine(composite);

            // String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            // Classes

            // Structs

            // Collections

            List<string> myList = new List<string>();
            myList.Add("Hello World!");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello World!");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "string");

            Stack<int> newStack = new Stack<int>();

            string banana = "Fruit";
            string[] stringArray = { "Hello", "Character", "Food", "Water" };
        }
    }
}
