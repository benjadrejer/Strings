using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------
            //Ask user for numbers separated by hyphens.
            //If the numbers are consecutive (either forwards or backwards)
            //Output "Consecutive", otherwise output "Non-consecutive".
            //    string input;
            //    var numbers = new List<int>();
            //    string message = "Consecutive";

            //    Console.WriteLine("Please type a list of numbers separated by hyphens(-)");
            //    input = Console.ReadLine();

            //    string[] inputArray = input.Split('-');

            //    foreach (var num in inputArray)
            //    {
            //        numbers.Add(Convert.ToInt32(num));
            //    }
            //    numbers.Sort();

            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        if (numbers[i] != numbers[i - 1] + 1)
            //        {
            //            message = "Non-consecutive";
            //        }
            //    }

            //    Console.WriteLine(message);
            //    Console.ReadKey();
            //}

            //----------------------------------------------------------------------
            //Ask the user for numbers separated by hyphens(-)
            //If the string is empty, exit.
            //Otherwise, check for duplicates.
            //If found, display "Duplicate".

            //string input;
            //var numbers = new List<int>();

            //Console.WriteLine("Please type a list of numbers separated by hyphens(-)");
            //input = Console.ReadLine();

            //if (!string.IsNullOrWhiteSpace(input))
            //{
            //    string[] inputArray = input.Split('-');

            //    foreach (var num in inputArray)
            //    {
            //        numbers.Add(Convert.ToInt32(num));
            //    }
            //    numbers.Sort();

            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        if (numbers[i] == numbers[i - 1])
            //        {
            //            Console.WriteLine("Duplicate found");
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercise3();
            //Exercise4();
            Exercise5();
            Console.ReadKey();
        }

        //-------------------------------------------------------------------------------
        //Ask user to input time in 24-hour format (00:00 to 23:59)
        //If valid, display "OK", otherwise, display "Invalid Time"

        public static void Exercise3()
        {

            string input;
            string[] components;

            Console.WriteLine("Please input a time in 24-hour format (00:00)");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }
   
            components = input.Split(':');
            if(components.Length != 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var hour = Convert.ToInt32(components[0]);
            var minutes = Convert.ToInt32(components[1]);

            if(hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            return;
        }

        //-------------------------------------------------------------------------------
        //Ask the user for a few words separated by whitespace.
        //Use these words to create a variable name with PascalCase
        //The program should work despite the input provided (upper or lowercase)
        public static void Exercise4()
        {
            string input;
            string[] words;

            Console.WriteLine("Please type a few words with whitespace between");
            input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            words = input.Split(' ');

            string variableName = "";
            foreach (var word in words)
            {
                char pascalLetter = char.ToUpper(word[0]);
                string substring = word.Substring(1);
                variableName += pascalLetter + substring;
            }

            Console.WriteLine(variableName);
            return;
        }

        //----------------------------------------------------------------------------------
        public static void Exercise5()
        {
            string input;
            int vowelCount = 0;

            Console.WriteLine("Please enter an English word");
            input = Console.ReadLine();

            foreach (var letter in input)
            {
                if(letter == 'a' || letter == 'o' || letter == 'e' || letter == 'i' || letter == 'u')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("Vowels: " + vowelCount);
            return;
        }
    }
}
