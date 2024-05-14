namespace AbstractClassAndInterface;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ISocialNetwork[] SocialNetworks { get; set; }

    public void PostToAll(string message)
    {
        foreach (var socialNetwork in SocialNetworks)
        {
            socialNetwork.Post($"{FirstName} {LastName}: {message}");
        }
    }
}