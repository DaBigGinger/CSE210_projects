using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Start breathing...");
        PerformBreathing();
    }

    public override void End()
    {
        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine($"You've spent {duration} seconds in total.");
    }

    private void PerformBreathing()
    {
        int remainingTime = duration;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds
            remainingTime -= 6; // 2 seconds for each breath
        }
    }
}
