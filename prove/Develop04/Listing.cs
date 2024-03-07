using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Start listing...");
        PerformListing();
    }

    public override void End()
    {
        Console.WriteLine("Good job! You have completed the Listing Activity.");
        Console.WriteLine($"You've spent {duration} seconds in total.");
    }

    private void PerformListing()
    {
        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(randomPrompt);
        Console.WriteLine("You have several seconds to think about the prompt...");
        Thread.Sleep(7000); // Pause for 7 seconds
        Console.WriteLine("Time's up!");
        // Additional logic can be added to allow the user to input items and count them
    }
}
