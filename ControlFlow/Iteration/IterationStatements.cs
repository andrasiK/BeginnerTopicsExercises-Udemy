using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{ 
  class IterationStatements
  {
    public static void Exercise1()

    {
        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        // Display the count on the console.
        int number = 1;
        int counter = 0;
        for (int i = 0; i < 100; i++)
        {
            if (number % 3 == 0)
            {
                counter++;
            }

            number++;
        }
        Console.WriteLine(counter+" numbers are divisible by 3 with no remainder between 1 and 100.");
        Console.ReadLine();

    }

    public static void Exercise2()
    {
        // Write a program and continously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers

        int number;
        string display;
        int sum = 0;
        bool stop = false;

        do
        {
            Console.WriteLine("Please enter a number or \"OK \" to exit. ");
            display = Console.ReadLine();

            if (display == "ok" || display == "OK")
            {
                stop = true;
            }
            else
            {
                bool success = int.TryParse(display, out number);
                if (success)
                {
                    sum = sum + number;
                }

            }

        } while (stop != true);

        Console.WriteLine("The sum of the numbers you entered is {0}", sum);
        Console.ReadLine();


    }


        
    public static void Exercise3()
    {
            // Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.
            /*A factorial is a function that multiplies a number by every number below it.*/

        int factorialNumber;
        int belowNumber = 1;
        int sum = 1;


        Console.WriteLine("Please enter a number to calculate the factorial of it: ");
        bool success = int.TryParse(Console.ReadLine(), out factorialNumber);
        if (success)
        {
            for (int i = 0; i < factorialNumber; i++)
            {
                sum = sum * belowNumber;
                    belowNumber++;
            }
            Console.WriteLine("The factorial of {0} is {1}", factorialNumber, sum);
        }
        else
        {
            Console.WriteLine("Error happened :(");
        }
        Console.ReadLine();
    }



        
    public static void Exercise4()
    {
     // Write a program, that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
     // If the user guessed the number, display "You won"; otherwise, display "You lost";


        var random = new Random();
        int randomNumber = random.Next(0, 10);
        int guess = -1;
        int counter = 1;

            while ((guess != randomNumber) && (counter <= 4))
            {
                Console.WriteLine("Guess the number between 1 and 10");
                guess = int.Parse(Console.ReadLine());
                
                if (guess == randomNumber)
                {
                    Console.WriteLine("You won! The number is {0}", randomNumber);
                }
                else if (counter == 4 && guess != randomNumber)
                {
                    Console.WriteLine("You lose! The number is {0}", randomNumber);
                }

                counter++;
            }
            
            Console.ReadLine();
    }

        
    public static void Exercise5()
    {
        // Write a program and ask the user to enter a series of numbers separated by comma.
        // Find the maximum of the numbers and display it on the console. 


        Console.WriteLine("Please enter a series of numbers separated by comma.");
        Console.WriteLine("For example:");
        Console.WriteLine("5,3,8,1,4");
        Console.WriteLine();

        string input = Console.ReadLine();
        string[] stringNumberArray = input.Split(',');
        int[] intNumbers = Array.ConvertAll(stringNumberArray, int.Parse);
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("The maximum number is: {0}", intNumbers.Max());

        Console.ReadLine();

    }
      

  }
}
