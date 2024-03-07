using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Program!");

        while (true) // Loop to allow multiple activities
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectionActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        Console.Write("Enter duration for Breathing Activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        BreathingActivity breathingActivity = new BreathingActivity(duration);
        breathingActivity.Start();
        breathingActivity.End();
    }

    static void RunReflectionActivity()
    {
        Console.Write("Enter duration for Reflection Activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
        reflectionActivity.Start();
        reflectionActivity.End();
    }

    static void RunListingActivity()
    {
        Console.Write("Enter duration for Listing Activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        ListingActivity listingActivity = new ListingActivity(duration);
        listingActivity.Start();
        listingActivity.End();
    }
}
