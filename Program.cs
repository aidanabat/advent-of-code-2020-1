using System;
using System.Collections.Generic;

namespace AOC_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string findTwo()
            {
                int amountsTo = 2020;
                //Get input and put into a giant list
                string inputNumbLine;
                List<int> numbersArray = new List<int>();
                System.IO.StreamReader file = new System.IO.StreamReader("input.txt");
                while ((inputNumbLine = file.ReadLine()) != null)
                {
                    int num = Int32.Parse(inputNumbLine);
                    if (num <= 2020)
                    {
                        numbersArray.Add(num);
                    }
                }
                file.Close();

                //Find the two numbers
                for (int floor = 0; floor < numbersArray.Count; floor++)
                {
                    for (int numberToTest = floor; numberToTest < numbersArray.Count; numberToTest++)
                    {
                        Console.WriteLine(String.Format("Testing {0} and {1}", numbersArray[floor], numbersArray[numberToTest]));
                        if (numbersArray[floor] + numbersArray[numberToTest] == amountsTo)
                        {
                            return String.Format("{0} + {1} is equal to {2}. {0} * {1} is equal to {3}", numbersArray[floor], numbersArray[numberToTest], numbersArray[floor] + numbersArray[numberToTest], numbersArray[floor] * numbersArray[numberToTest]);
                        }
                    }
                }
                return "None Found";
            }


            Console.WriteLine(findTwo());
            //pause
            System.Console.ReadLine();
        }
    }
}
