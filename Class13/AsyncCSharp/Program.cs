using System.Net.WebSockets;

namespace AsyncCSharp;

public class Program
{
    public static void Main()
    {
        Task myFirstTask = new Task(() => 
        {
            Console.WriteLine("#2. The task started");

            // Simulate long running operation which lasts 5seconds
            Thread.Sleep(2000);

            Console.WriteLine("#3. 2 seconds passed");
        });

        Task<string> calculationTask = new Task<string>(() =>
        {
            Console.WriteLine("#2. The task started");

            // Simulate long running operation which lasts 5seconds
            Thread.Sleep(10000);

            Console.WriteLine("#3. 10 seconds passed");

            return "The calucation result was 100";
        });

        Console.WriteLine("#1. This is first line of code executed");

        //myFirstTask.Start();
        calculationTask.Start();

        //SynchronousCodeExecution();

        Console.ReadLine();

        string username = "Almir";
        Console.WriteLine($"#4. ENDDD This is second line of code executed for user {username}");

        Console.WriteLine("#5." + calculationTask.Result);
    }

    static void SynchronousCodeExecution()
    {
        Console.WriteLine("#2. Non async: code started");

        // Simulate long running operation which lasts 5seconds
        Thread.Sleep(10000);

        Console.WriteLine("#3. Non async code : 5 seconds passed");
    }
}