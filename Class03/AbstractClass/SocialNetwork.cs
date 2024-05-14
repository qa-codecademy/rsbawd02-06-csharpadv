namespace AbstractClass;

public abstract class SocialNetwork 
{
    public string Name { get; protected set; }

    public virtual void Post(string message)
    {
        Console.WriteLine($"Posting to {Name}: {message}");
    }
}