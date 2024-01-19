using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };


            /* Create a list of type int
             * Name the list "evens"
             */
            var evens = new List<int>();


            /* Create another list of type int
             * Name the list "odds"
             */
            var odd = new List<int>();

            /* Using either a foreach or for loop,
            * iterate through the array you populated with 10 numbers.
            * Inside the scope of the loop,
            * check to see if each number in the array is even or odd.
            * If the number is even, add it to the evens list.
            * If the number is odd, add it to the odds list.
            */

            foreach (int n in myArray)
            {
                if(n % 2 == 0) 
                {
                    evens.Add(n);
                    Console.WriteLine($"{n}");
                }
                else 
                {
                    odd.Add(n);
                    Console.WriteLine($"{n}");
                }
            }

            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */


            /* Using a for loop,
             * display the numbers in your "odds" list
             */

            Console.WriteLine();

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is pretty even");
            }

            foreach (var oddnum in odd)
            {
                Console.WriteLine($"{oddnum} is crazy odd");
            }

        }
    }
}
