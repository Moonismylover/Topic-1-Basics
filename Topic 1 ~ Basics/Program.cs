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
            Console.WriteLine("Hello, World!");

            Console.WriteLine();

            // Assigning a value to a variable
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            Console.WriteLine();

            // Reassigning a value to a variable
            aFriend = "Maria";
            Console.WriteLine(aFriend);

            Console.WriteLine();

            // Sentence with variable and string
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            Console.WriteLine();

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine();

            Console.WriteLine();

        }
    }
}
