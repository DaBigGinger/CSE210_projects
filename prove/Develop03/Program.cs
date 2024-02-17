using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
    // Call Verse and reference to display
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ");

        while (!scripture.AllWordsHidden())
        {
            scripture.Display(reference);
            Console.WriteLine("Enter the number of words to hide, or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Check if the input is "quit" or if it's a valid number
            if (input.ToLower() == "quit")
            {
                break;
            }

            int numWordsToHide;
            if (!int.TryParse(input, out numWordsToHide))
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type 'quit' to exit.");
                continue;
            }

            // Hide the specified number of words
            scripture.HideRandomWords(numWordsToHide);
        }
    }

}
