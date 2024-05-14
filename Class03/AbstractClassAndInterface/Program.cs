// See https://aka.ms/new-console-template for more information
using AbstractClassAndInterface;

Console.WriteLine("Hello, World!");

var milica = new User();
milica.FirstName = "Milica";
milica.LastName = "Knezevic";
milica.SocialNetworks = [new Facebook(), new Twitter()];

var tamara = new User();
tamara.FirstName = "Tamara";
tamara.LastName = "Dojcinovic";
tamara.SocialNetworks = [new Facebook()];

milica.PostToAll("Hello, World!");
tamara.PostToAll("Hello, my World!");



var users = new User[] {milica, tamara};

var fb = new Facebook();
fb.FbLogo = new Logo();

//PostHelloMessage(new Facebook());
//PostHelloMessage(new Twitter());


//void PostHelloMessage(SocialNetwork socialNetwork)
//{
//    socialNetwork.Post("Hello, World from a common method!");
//}