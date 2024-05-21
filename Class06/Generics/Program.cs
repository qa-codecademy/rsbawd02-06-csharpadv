using Generics.Extensions;
using Generics.Models;
using Generics.Utils;
using System.Collections.Concurrent;

namespace Generics;

class Program
{
    static void Main(string[] args)
    { 
        List<string> listOfStrings = new List<string>();

        listOfStrings.Add("some");
        listOfStrings.Add("testing");
        listOfStrings.Add("words");
        listOfStrings.Add("to learn");
        listOfStrings.Add("about generics");

        List<int> listOfInts = new List<int>() { 1, 2, 3, 4, 6, 6, 21, 21, 22, };
        List<double> listOfFloats = new List<double>() { 1.5, 2.5, 3.2, 4, 6, 6, 21, 21, 22, };
        List<char> listOfChars = new List<char> { 'a', 'l', 'm', 'i', 'r' };

        ListHelper<string> stringHelper = new ListHelper<string>();
        stringHelper.GoThroughList(listOfStrings);

        ListHelper<int> integerHelpers = new ListHelper<int>();
        integerHelpers.GoThroughList(listOfInts);

        ListHelper<char> charHelpers = new ListHelper<char>();
        charHelpers.GoThroughList(listOfChars);

        charHelpers.GetInfo(listOfChars);

        //if (charHelpers.GetType() == typeof(ListHelper<char>))
        //{

        //}

        Product product1 = new Product();
        product1.Id = 1;
        product1.Title = "Coca Cola";
        product1.Description = "Soft non alcoholic drink, 1l";

        Product product2 = new Product();
        product2.Id = 2;
        product2.Title = "Coca Cola Zero";
        product2.Description = "Soft non alcoholic, no sugar drink, 1l";

        Order order1 = new Order();
        order1.Id = 10;
        order1.Reciever = "Zoran Malinovic";
        order1.Address = "Banja Luka bb";

        Order order2 = new Order();
        order2.Id = 11;
        order2.Reciever = "Miroslav Popovic";
        order2.Address = "Banja Luka bb";

        Console.WriteLine("-----------------------------");

        PrintInfo(product1);
        PrintInfo(product2);

        PrintInfo(order2);
        PrintInfo(order1);

        // Invalid usage of Generic method PrintInfo
        //PrintInfo(listOfChars);
        //PrintInfo("hehe");

        Console.WriteLine("-------------------------------------------------------");

        string randomSentence = "Danas je lijep dan, ucimo C# svi zajedno";

        string shortenedString = StringExtensions.Shorten(randomSentence, 3);

        string shortenedString2 = randomSentence.Shorten(3);

        Console.WriteLine("Unesite neki broj: ");
        string userInput = Console.ReadLine();

        int number = userInput.ParseToInt();

        Console.WriteLine($"Unijeli ste broj: {number}");

        Console.WriteLine(shortenedString2);

        int a = 10;
        int b = 20;

        if (a.IsGreaterThan(b))
            Console.WriteLine("Prv je veci");
        else
            Console.WriteLine("Drugi je veci");
    }

    public static void PrintInfo<T>(T item) where T : BaseEntity
    {
        Console.WriteLine(item.GetInfo());
    }
}