using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFiles
{
    class WorkWithFiles
    {
        //**************************************//
        // Basic example for working with files //
        //**************************************//
        public static void Exercise1()
        { 
            string path = @"c:\Users\andra\Programming\Kristof\Files\MyFile.txt";

            // if file doesn't exitsts
            if (!File.Exists(path))
            {
                // Create the file
                string initialText = "Hello this is a new file" + Environment.NewLine;
                File.WriteAllText(path, initialText, Encoding.UTF8);
            }

            // append text for it every time
            string appendText = "This text was added to the file" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);

            // Open the file and read it
            string fileText = File.ReadAllText(path);
            Console.WriteLine(fileText);
            Console.ReadLine();

        }

        public static void Exercise2()
        {
            //**************************************************************************//
            //Write a program that reads a text file and displays the number of words.  //
            //**************************************************************************//

            string path = @"c:\Users\andra\Programming\Kristof\Files\MyFile.txt";
            string fileString = File.ReadAllText(path);


            string[] wordsFromFile = fileString.Split(new string[] { " ", "\r\n", "\n" }, StringSplitOptions.None);
            int numberOfWords = wordsFromFile.Count();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(fileString);
            Console.WriteLine();
            Console.WriteLine("************************************************");
            //Not to count the last new line
            Console.WriteLine("This file has {0} words in it. ", (numberOfWords - 1));
            Console.ReadLine();

        }
        public static void Exercise3()
        {
            //*******************************************************************************//
            // Write a program that reads a file and displays the longest word in the file.  //
            //*******************************************************************************//

            string path = @"c:\Users\andra\Programming\Kristof\Files\MyFile.txt";
            string fileString = File.ReadAllText(path);
            string longest = "";

            string[] wordsFromFile = fileString.Split(new string[] { " ", "\r\n", "\n" }, StringSplitOptions.None);
            longest = wordsFromFile[0];
            for (int i = 0; i < (wordsFromFile.Length) - 1; i++)
            {
                int count1 = wordsFromFile[i].Count();
                int count2 = wordsFromFile[i + 1].Count();
                if (count1 < count2 && count2 > longest.Count())
                {
                    longest = wordsFromFile[i + 1];
                }

            }

            Console.WriteLine("The file contains this text: ");
            Console.WriteLine();
            Console.WriteLine("\"" + fileString + "\"");
            Console.WriteLine();
            Console.WriteLine("***************************************************************");
            Console.WriteLine("The longest word from the file is: ");
            Console.WriteLine();
            Console.WriteLine(longest);
            Console.ReadLine();

        }
    }
}
