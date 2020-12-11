using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Strings
    {
        public static void Exercise1()
        {
            //********************** Exercise 1 ***********************************************//
            // Write a program and ask the user to enter a few numbers separated by a hyphen.  //
            // Work out if the numbers are consecutive.                                         //
            // If yes, display a message: "Consecutive"; otherwise, display "Not Consecutive"  //
            //*********************************************************************************//
            //Consecutive numbers are numbers that follow each other in order from the smallest number to the largest number.
            string inputString;
            List<int> numbersList = new List<int>();
            bool isConsecutive = true;

            Console.WriteLine("Please enter a few numbers separated by a hyphen: ");
            Console.WriteLine("For example: 5-6-7-8-10");

            inputString = Console.ReadLine();

            // Another way to create number List
            foreach (var number in inputString.Split('-'))
            {
                numbersList.Add(Convert.ToInt32(number));
            }

            // is consecutive?
            for (int i = 1; i < numbersList.Count(); i++)
            {
                if (numbersList[i] != numbersList[i - 1] + 1)
            
                {
                    isConsecutive = false;
                    break;
                }
            }

            // use of the ternary conditional operator
            string message = isConsecutive ? "consecutive" : "not consecutive";
            Console.WriteLine("The numbers you gave are {0}. ",message);
            Console.ReadLine();

        }

        public static void Exercise2()
        {
            //*******************************************************************************************//
            // Write a program and ask the user to enter a few numbers separated by a hyphen.            //
            // If the user simply presses Enter, without supplying an input, exit immedetialy.           //
            // Otherwise check to see if there are duplicates. If so, display "Duplicate" in the console.//
            //*******************************************************************************************//

            string input;
            List<int> numbers = new List<int>();
            bool duplicate = false;

            Console.WriteLine("Please enter a few numbers separated by a hyphen: ");
            Console.WriteLine("For example: 5-6-7-8-10");

            input = Console.ReadLine();

            //Checking if no input
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(":(");
            }
            else
            {
                //Convert to integer
                foreach (var number in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                //Go through the list at every number, to see are there any duplicates
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    for (int j = 1; j < numbers.Count; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            duplicate = true;
                            break;
                        }
                        j++;
                    }
                    i++;
                }
                                    
                string conclusion = duplicate == true ? "Duplicate" : "No duplicates";
                Console.WriteLine(conclusion);

            }
            Console.ReadLine();
        }


        public static void Exercise3()
        {
          //*************************************************************************************************//
          // Write a program and ask the user to enter a time value in the 24-hour time format (e.g 19:00).  //
          // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,  //
          // display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.    //
          //*************************************************************************************************//

            List<int> timeValues = new List<int>();
            bool bad;

            Console.WriteLine("Please enter a time in the 24-hour time format: ");
            Console.WriteLine("e.g 19:00");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                bad = true;
            }
            else
            {
                foreach (var number in input.Split(':'))
                {
                    timeValues.Add(Convert.ToInt32(number));
                }

                if (timeValues[0] >= 0 && timeValues[0] < 24
                    && timeValues[1] >= 0 && timeValues[1] < 60)
                {
                    bad = false;
                }
                 else
                 {
                     bad = true;
                 }

            }

            string message = bad ? "Invalid Time" : "OK";
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(message);
            Console.ReadLine();
        }

        
  //      public static void Exercise4()
  //      {
            //******************************************************************************************************//
            // Write a program and ask the user to enter a few words separated by a space. Use the words to create  //
            // a variable name with PascalCase. Make sure that the program is not dependent on the input.           //
            // So if the user enters "NUMBER OF STUDENTS", the program should still display "NumberOfStudents"      //
            //******************************************************************************************************//
/*
            List<int> pascalPlace = new List<int>();

            Console.WriteLine("Please enter a few words separated by space: ");
            string input = Console.ReadLine().ToLower();
            char[] charInput = input.ToCharArray();
            charInput[0] = Char.ToUpper(charInput[0]);

            for (int i = 0; i < charInput.Length; i++)
            {
                if (Char.IsWhiteSpace(charInput[i]))
                {
                    charInput[i + 1] = Char.ToUpper(charInput[i + 1]);
                }
            }

            string toBeTrimmed = new string(charInput);
            string trimmed = string.Concat(toBeTrimmed.Where(c => !Char.IsWhiteSpace(c)));


            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(trimmed);
            Console.ReadLine();
        }

        */
   //     public static void Exercise5()
   //     {
            //****************************************************************************************************************//
            // Write a program and ask the user to enter an English word. Count the number of vowels (a,e,o,u,i) in the word. //
            //****************************************************************************************************************//

            // an array as a list item...
     /*       var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            int counter = 0;

            Console.WriteLine("Please enter an English word: ");
            string word = Console.ReadLine();
            string lowerWord = word.ToLower();
            char[] wordArray = word.ToCharArray();

            // search in vowels for characters from wordArray!
            foreach (char c in wordArray)
            {
                if (vowels.Contains(c))
                {
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("The word '{0}' contains {1} vowels", word, counter);
            Console.ReadLine();

        }
     */
    }
}
