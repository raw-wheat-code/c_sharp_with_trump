public static class ConsoleMessaging
{
    public static void SomethingWentWrong()
    {
        Console.Clear();
        Console.WriteLine("Something went wrong. Please try again.");
        Console.WriteLine("\nPress ENTER to continue...");
        Console.ReadLine();
    }

    public static void Loading()
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Clear();
            Console.Write("Loading");
            WaitingPeriods(i);
        }
    }

    public static void Unconstitutional()
    {
        Console.WriteLine("I’m sorry, that’s unconstitutional.\n");
        Console.WriteLine("Press ENTER to continue...");
    }

    public static void SelfDestruct()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.Clear();
            Console.WriteLine("Liberty compromised. Self-destruct sequence initiated:");
            Console.Write($"\n{i}");
            WaitingPeriods(0);
        }
        Console.Clear();
        Console.WriteLine("America terminated.");
        Environment.Exit(0);
    }

    public static void WaitingPeriods(int i)
    {
        for (int j = 0; j < 3 - i; j++)
        {
            Console.Write(" .");
            Thread.Sleep(400);
        }
    }
}