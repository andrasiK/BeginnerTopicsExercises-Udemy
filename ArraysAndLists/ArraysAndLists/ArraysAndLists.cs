using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class ArraysAndLists
    {
        public static void Exercise1()
        {
            //*********************************************************************************************************************************//
            // When you post a message on Facebook, depending on the number of people who like your post, Facebook 
            // displays different information. 
            //   - if no one like your post, it doesn't display anything
            //   - if only one person likes your post, it displays: [Friend's name] likes your post
            //   - if two people like your post, it displays: [Friend1] and [Friend2] like your post
            //   - if more then two people like your post, it displays [Friend1],[Friend2] and [Number of other people] others
            //     like your post
            //
            // Write a program and continuously ask the user to enter different names, until the user presses Enter [without supplying a name] 
            // Depending the number of names provided, display a message based on the above pattern. 
            //**********************************************************************************************************************************//

            List<string> names = new List<string>();
            bool looping = true;

            do
            {
                Console.WriteLine("Please enter a name: ");
                string actualName = Console.ReadLine();
                if (String.IsNullOrEmpty(actualName))
                {
                    looping = false;
                }
                else
                {
                    names.Add(actualName);
                }
            } while (looping);

            int namesCount = names.Count();
            if (namesCount == 0)
            {
                Console.WriteLine("Sorry buddy, no likes    :(   ");
            }
            else
            {
                switch (namesCount)
                {
                    case 1:
                        Console.WriteLine("{0} likes your post", names.First());
                        break;
                    case 2:
                        Console.WriteLine("{0} and {1} likes your post", names.First(), names[1]);
                        break;
                    default:
                        Console.WriteLine("{0} and {1} and {2} others like your post", names[0], names[1], (names.Count() - 2));
                        break;
                }

            }
            Console.ReadLine();
        }

      
        public static void Exercise2()
        {
            //************************** Exercise 2 ********************************************************//
            // Write a program and ask the user to enter their name. Use an array to reverse the name and   //
            // then store the results in a new string. Display the reversed name on the console.            //
            //**********************************************************************************************//
            
            string inputName;
            Console.WriteLine("Please enter your name: ");
            inputName = Console.ReadLine();
            Console.WriteLine();
            char[] charArray = inputName.ToCharArray();

            Array.Reverse(charArray);
            string reversed = new string(charArray);
               

            Console.WriteLine("The given name reversed is: {0}",reversed);
            Console.ReadLine();

        }
            
        public static void Exercise3()
        {
            //**************************** Exercise 3 ***************************************************************//
            // Write a program and ask the user to enter 5 number. If a number has been previously entered,          //
            // display an error message and ask the user to re-try.                                                  //
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.  //
            //*******************************************************************************************************//

            int[] numberArray = new int[5];
            int arrayElement = 0;
            int count = 0;
            int givenNumber;
            bool bad = false;
            do
            {
                Console.WriteLine("Please enter a number: ");
                bool success = Int32.TryParse(Console.ReadLine(), out givenNumber);

                if (success)
                {
                    if (numberArray.Contains(givenNumber))
                    {
                        Console.WriteLine("Please use distinct numbers!");
                    }
                    else
                    {
                        numberArray[arrayElement] = givenNumber;
                        arrayElement++;
                        count++;
                    }

                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Something bad happened :(");
                    bad = true;
                    break;
                }

            } while (count < 5);


            if (bad == false)
            {
                Array.Sort(numberArray);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("The given numbers are: ");
                foreach (var item in numberArray)
                {
                    Console.Write(item + ", ");
                   
                }
            }
            Console.ReadLine();
        }


        public static void Exercise4()
        {
            //**************************** Exercise 4 ***************************************************************//
            // Write a program and ask the user to continously enter a number or type "Quit" to exit.                //
            // The list of numbers may include duplicates. Display the unique numbers that the user has entered      //
            //*******************************************************************************************************//

            int inputNumber;
            string input;
            bool displayUnique = false;
            bool inputError = false;
            List<int> numbers = new List<int>();
            int listElement = 0;

            do
            {
                Console.WriteLine("Please enter a number: ");
                input = Console.ReadLine();
                bool success = Int32.TryParse(input, out inputNumber);

                if (success)
                {
                    numbers.Add(inputNumber);
                    listElement++;
                }
                else
                {
                    if (input == "Quit")
                    {
                        displayUnique = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Something bad happened   :( ");
                        inputError = true;
                    }
                }

            } while (displayUnique == false && inputError == false);

            List<int> uniqueList = numbers.Distinct().ToList();
            if (displayUnique == true)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("The unique numbers from the entered list are: ");
                foreach (var a in uniqueList)
                {
                    Console.WriteLine("{0}", a);
                }
            }

            Console.ReadLine();
        }

        public static void Exercise5()
        {
            //**************************** Exercise 5 ***************************************************************//
            // Write a program and ask the user to supply a list of comma separated numbers. If the list is empty or //
            // includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display   //
            // the 3 smallest numbers in the list.                                                                   //
            //*******************************************************************************************************//

            string input;
            List<string> stringNumbers = new List<string>();
            List<int> numbers = new List<int>();
            bool looping = true;

            // Ask for input
            Console.WriteLine("Please type in a list of comma separated numbers: ");
            Console.WriteLine("e.g 5,1,9,2,10");



            do
            {
                input = Console.ReadLine();

                // If no input
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine("Please re-enter the values:");
                }

                else
                {
                    stringNumbers = input.Split(',').ToList();
                    // IF less then 5 numbers
                    if (stringNumbers.Count() < 5)
                    {
                        Console.WriteLine("Invalid List");
                        Console.WriteLine("Please re-enter the values:");
                    }
                    // Input is OK
                    else
                    {
                        // change to integer type with lambda expression
                        numbers = stringNumbers.Select(x => Int32.Parse(x)).ToList();
                        numbers.Sort();
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("The 3 smallest numbers in the list are: ");
                        Console.WriteLine("{0}, {1} and {2}", numbers[0], numbers[1], numbers[2]);
                        looping = false;
                    }
                }

            } while (looping);

            Console.ReadLine();
        }
         
              
    }
}
