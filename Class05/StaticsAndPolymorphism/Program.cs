using StaticsAndPolymorphism.Helpers;
using StaticsAndPolymorphism.Models;

namespace StaticsAndPolymorphism;

class Program
{
    static void Main(string[] args)
    {
        string word1 = "mostar";
        string word2 = "qinshift";
        string word3 = "a";
        string word4 = "";

        // we dont need to do this!
        // TextHelpers th = new TextHelpers();
        // eWord1 = th.CapitalFirstLetter(word1);

        string eWord1 = TextHelpers.CapitalFirstLetter(word1);
        string eWord2 = TextHelpers.CapitalFirstLetter(word2);
        string eWord3 = TextHelpers.CapitalFirstLetter(word3);
        string eWord4 = TextHelpers.CapitalFirstLetter(word4);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord3 = TextHelpers.CapitalFirstLetter(word3);
        eWord4 = TextHelpers.CapitalFirstLetter(word3);

        Console.WriteLine($"Edited word: {eWord1}");
        Console.WriteLine($"Edited word: {eWord2}");
        Console.WriteLine($"Edited word: {eWord3}");
        Console.WriteLine($"Edited word: {eWord4}");

        Console.WriteLine($"The method was used {TextHelpers.CapitalLetterUses}");

        eWord4 = TextHelpers.CapitalFirstLetter(word3);

        Console.WriteLine($"The method was used {TextHelpers.CapitalLetterUses}");
      
        string broj = "10";
        int brojNum = Int32.Parse(broj);

        string someWeirdWord = "aLMIr";

        string editedInvertedWord = TextHelpers.InvertMeCapitalizedChars(someWeirdWord);

        Console.WriteLine(editedInvertedWord);

        string sentence = "Mi danas ucimo C# na predmetu C# Advanced : Statics and Polymorphism";

        Console.WriteLine($"Number of capital chars is: {TextHelpers.NumberOfCapitalLetters(sentence)}");

        Console.WriteLine("------- polymorphism");

        Dog dog = new Dog();
        dog.Name = "Rex";

        Cat cat = new Cat();
        cat.Name = "Cicko";

        // dog.Eat();
        CallEatMethod(dog);
        
        //cat.Eat();
        CallEatMethod(cat);

        PetStatus(dog, "Mike");
        PetStatus(cat);

    }

    // Usage of runtime polymorphism
    public static void CallEatMethod(Pet pet)
    {
        pet.Eat();
    }

    // Static polymorphism (method overloading)
    public static void PetStatus(Dog dog, string ownerName)
    {
        Console.WriteLine($"Hi {ownerName}");

        if (dog.IsGoodBoi)
            Console.WriteLine("This dog is a good boi");
        else
            Console.WriteLine("This dog is not a god boi :(((");
    }

    public static void PetStatus(string ownerName, Dog dog, DateTime birth)
    {
        Console.WriteLine($"Hi {ownerName}");

        if (dog.IsGoodBoi)
            Console.WriteLine("This dog is a good boi");
        else
            Console.WriteLine("This dog is not a god boi :(((");

        Console.WriteLine($"Dog birthday is {birth.ToShortDateString()}");
    }

    public static void PetStatus(Cat cat, string ownerName)
    {
        Console.WriteLine($"Hi {ownerName}");

        if (cat.IsLazy)
            Console.WriteLine("This cat is a lazy cat");
        else
            Console.WriteLine("This cat is not a lazy cat, she plays all the time");
    }
    
    public static void PetStatus(Cat cat)
    {
        Console.WriteLine("This cat has no owner :((");

        if (cat.IsLazy)
            Console.WriteLine("This cat is a lazy cat");
        else
            Console.WriteLine("This cat is not a lazy cat, she plays all the time");
    }
}