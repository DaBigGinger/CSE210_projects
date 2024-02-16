using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
        {
        // Call Verse and reference to display
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life. ");
        
        while (!scripture.AllWordsHidden())
        {
            scripture.Display(reference);
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords();
        }
    }
}
