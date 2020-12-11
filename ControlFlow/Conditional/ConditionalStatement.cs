using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class ConditionalStatement
    {
        public static void Exercise1()
        {
            // Write a program and ask the user to enter a number. The number should be between 1 and 10.
            // If the user enters valid number, display "Valid" on the console. Otherwise display "Invalid".


            Console.WriteLine("Please enter a number between 1 and 10! ");

            int enteredValue = int.Parse(Console.ReadLine());

            string answer = (enteredValue > 0 && enteredValue < 11) ? "Valid" : "Invalid";
            Console.WriteLine(answer);
            
            Console.ReadLine();
        }
        
        public static void Exercise2()
        {

            // Write a number which takes two numbers from the console and displays the maximum of the two.    

            Console.WriteLine("Please enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the two numbers is: {0}", number1+number2);

            Console.ReadLine();

        }

        public static void Exercise3()
        {
            // Write a program and ask a user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait. 

            Console.WriteLine("Please enter the widht of the image: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the image: ");
            int height = int.Parse(Console.ReadLine());

            string imageType = width > height ? "landscape" : "portrait";
            Console.WriteLine("The image is a {0}.",imageType);
            
            Console.ReadLine();

        }

        public static void Exercise4()
        {
            // Speed camera: Write a program that asks for speed limit. Once set, the program asks for the speed of a car. 
            // If the user enters a value less than the speed limit, program should display OK on the console. 
            // If the value is above the speed limit, the program should calculate the number of demerit points. 
            // For every 5km/h above speed limit, 1 demerit point should be incurred and and displayed on the console. 
            // If the number of demerit points is above 12, the program should display "License Suspended"


            Console.WriteLine("Please enter the speed limit: ");
            int sLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car: ");
            int speed = int.Parse(Console.ReadLine());

            DemeritPointsCalculation(sLimit, speed);

            Console.ReadLine();

            
            void DemeritPointsCalculation(int limit, int actualSpeed)
            {
                // Speed limit OK
                if (actualSpeed <= limit)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    //Calculate demerit points
                    int demeritPoints = 1;
                    int speedAboveLimit = limit;

                    //Going up from the limit speed to the actual speed adding +5 in every step
                    //At every +5km/h one additional demerit point is added 
                    while (speedAboveLimit <= actualSpeed)
                    {
                        if ((speedAboveLimit + 5) - 1 <= actualSpeed)
                        {
                            demeritPoints++;
                        }
                        speedAboveLimit = speedAboveLimit + 5;
                    }

                    if (demeritPoints < 12)
                    {
                        Console.WriteLine("Speeding! You have {0} demerit points.", demeritPoints.ToString());
                    }

                    else
                    {
                        Console.WriteLine("Speeding! License Suspended.");
                    }

                }

            }

        }
        

    }
}



    