namespace Interface;

public class Twitter : ISocialNetwork
{
    public string Name { get; protected set; } = "Twitter";

    public void Post(string message)
    {
        Console.WriteLine($"Posting to {Name}: {message}");
    }
}