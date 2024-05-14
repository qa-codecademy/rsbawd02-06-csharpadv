namespace AbstractClassAndInterface;

public interface ISocialNetwork
{
    string Name { get; }

    void Post(string message);
}