namespace AbstractClassAndInterface;

public abstract class SocialNetwork : ISocialNetwork
{
    public string Name { get; protected set; }

    public virtual void Post(string message)
    {
        Console.WriteLine($"Posting to {Name}: {message}");
    }
}