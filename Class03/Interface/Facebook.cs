namespace Interface;

public class Facebook : ISocialNetwork
{
    public string Name { get; } = "Facebook";

    public Logo FbLogo { get; set; } = new()
    {
        Url = "https://www.facebook.com/images/fb_icon_325x325.png",
    };

    public void Post(string message)
    {
        Console.WriteLine($"Posting to {Name} with logo {FbLogo.Url}: {message}");
    }
}