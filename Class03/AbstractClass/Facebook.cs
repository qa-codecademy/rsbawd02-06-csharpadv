namespace AbstractClass;

public class Facebook : SocialNetwork
{
    public Logo FbLogo { get; set; }

    public Facebook()
    {
        Name = "Facebook";
        FbLogo = new Logo
        {
            Url = "https://www.facebook.com/images/fb_icon_325x325.png",
        };
    }

    public override void Post(string message)
    {
        Console.WriteLine($"Posting to {Name} with logo {FbLogo.Url}: {message}");
    }
}