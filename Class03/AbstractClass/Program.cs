using AbstractClass;

Console.WriteLine("Hello, World!");

var milica = new User
{
    FirstName = "Milica",
    LastName = "Knezevic",
    SocialNetworks = [new Facebook(), new Twitter()]
};

var tamara = new User
{
    FirstName = "Tamara",
    LastName = "Dojcinovic",
    SocialNetworks = [new Facebook()]
};

milica.PostToAll("Hello, World!");
tamara.PostToAll("Hello, my World!");
