using System;

class Program
{
    static void Main(string[] args)
    {
        // Gathering Information for parts 1 & 2 where magic number is chosen
        Console.WriteLine("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());
        int guess = -1;
        // Loop to guide the user higher or lower if guess is wrong
        while (guess != magicNum)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! ");
            }

        }
    }

}
