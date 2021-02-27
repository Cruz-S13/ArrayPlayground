using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayGames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array and accept input from a user

            Console.WriteLine("Hello, please choose 4 single-digit numbers:");
            int[] arrayGames = new int[4];

            // User input loop, 4 numbers up to 9999, then displays the numbers
            for (int i = 0; i < arrayGames.Length; i++)
            {
                arrayGames[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrayGames.Length; i++)
            {
                Console.Write(arrayGames[i] + " ");
            }
            Console.WriteLine("Are the numbers you have chosen.");

            // Adding the numbers of the array
            int sum = arrayGames.Sum();
            Console.WriteLine($"\nThe sum of your numbers is: {sum}.\n");

            // Reversing the numbers in the array, then display
            Array.Reverse(arrayGames);
            Console.WriteLine("The reverse order of your numbers are:");
            for (int i = 0; i < arrayGames.Length; i++)
            {
                Console.Write(arrayGames[i] + " ");
            }
            // Place array back in the original order
            Array.Reverse(arrayGames);
            Console.WriteLine(); // Just making a new line for the next sequence

            //Swap the first and last numbers in the array
            int first = 0;
            first = arrayGames[0];
            arrayGames[0] = arrayGames[3];
            arrayGames[3] = first;
            Console.WriteLine();

            //Print the array, with the numbers swapped
            for (int i = 0; i < arrayGames.Length; i++)
            {
                Console.Write(arrayGames[i] + " ");
            }
            Console.WriteLine("Are the numbers you have chosen, with your 1st and 4th numbers swapped.\n");

            // undo the last action of the swap, but now swap index 1 and 2.
            int last = 0; // initializing index 3, preparing for swap 
            int indexOne = 0; // initializing variable for storing current index 1
            last = arrayGames[3]; //storing index 3 into variable
            arrayGames[3] = arrayGames[0];
            arrayGames[0] = last;
            indexOne = arrayGames[1]; //storing current index 1 into variable
            arrayGames[1] = arrayGames[2]; //replacing value of index 1 with the value of index 2
            arrayGames[2] = indexOne; //replacing previous value of index 2 with stored old value from index 1
            for (int i = 0; i < arrayGames.Length; i++)
            {
                Console.Write(arrayGames[i] + " ");
            }
            Console.WriteLine("Are the numbers you have chosen, with your 2nd and 3rd numbers swapped.\n");

            // undoing element swap from the last sequence
            int indexTwo = 0; //storing current index 1 into variable
            indexTwo = arrayGames[2];
            arrayGames[2] = arrayGames[1]; //replacing value of index 1 with the value of index 2
            arrayGames[1] = indexTwo; //replacing previous value of index 2 with stored old value from index 1

            Console.ReadKey();
        }
    }
}
