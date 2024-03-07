using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Start reflecting...");
        PerformReflection();
    }

    public override void End()
    {
        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine($"You've spent {duration} seconds in total.");
    }

    private void PerformReflection()
    {
        Random random = new Random();
        int remainingTime = duration;
        while (remainingTime > 0)
        {
            string randomPrompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(randomPrompt);
            Thread.Sleep(3000); // Pause for 3 seconds
            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(3000); // Pause for 3 seconds
            }
            remainingTime -= 30; // 3 seconds for prompt, 3 seconds for each question (9 questions)
        }
    }
}
