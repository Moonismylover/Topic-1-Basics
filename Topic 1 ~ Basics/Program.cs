using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_1___Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hello World

            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Variables

            string aFriend = "Nyla";
            Console.WriteLine(aFriend);
            Console.WriteLine();

            // Reassigning value to variable

            aFriend = "Star";
            Console.WriteLine(aFriend);
            Console.WriteLine();

            // String + Variables
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine();

            // Combination of all the above
            string friendOne = "Rhea";
            string friendTwo = "Nocturna";
            Console.WriteLine($"My friends are {friendOne} and {friendTwo}");
            Console.WriteLine();

            // Finding the length of a string
            Console.WriteLine($"The name {friendOne} has {friendOne.Length} letters.");
            Console.WriteLine($"The name {friendTwo} has {friendTwo.Length} letters.");
            Console.WriteLine();

            // Trimming whitespace from a string
            string greetings = "     Hello World!     ";
            Console.WriteLine($"{greetings}");

                // Trims the start only
                string trimmedGreetings = greetings.TrimStart();
                Console.WriteLine($"[{trimmedGreetings}]");
            
                // Trims the end only
                trimmedGreetings = greetings.TrimEnd();
                Console.WriteLine($"[{trimmedGreetings}]");
                
                // Trims both the start and end
                trimmedGreetings = greetings.Trim();
                Console.WriteLine($"[{trimmedGreetings}]");

            // The brackets [] shows where the whitespace starts and ends. 

            Console.WriteLine();

            // Search + replace text in strings
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine();

            // Uppercase and Lowercase
            string Hello = "Hello!";
            Console.WriteLine(Hello.ToUpper());
            Console.WriteLine(Hello.ToLower());
            Console.WriteLine();

            // Finding text in a string
            string songLyrics = "I need someone to hold me close, deeper than I've ever known";
            Console.WriteLine(songLyrics.Contains("deeper"));
            Console.WriteLine(songLyrics.Contains("vulnerable"));

            // The output will be True and False respectively.

            /* 
            
            Questions 

             1. Provide 2 different ways to write a greeting to someone who’s name is stored in a string variable firstName? 
                Use string interpolation and the + operator. Which method do you prefer?
                
                string firstName = "Ace";
                Console.WriteLine("Hello " + firstName);
                Console.WriteLine)$"Hello {firstName}");
                
                I personally prefer the string interpolation method as it is quicker to write and less chances for mistakes.

             2. How would you print out the number of characters in a string called passPhrase?
                Console.WriteLine(__________________________);

                string passPhrase = "headphonesarepurple";
                Console.WriteLine(passPhrase.Length);
                
             3. What does the Trim() method do? Why might this be useful?

                The Trim() method removes whitespace. This is useful when 

            */
        }
    }
}
