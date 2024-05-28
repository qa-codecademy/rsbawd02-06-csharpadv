using LinqRecap.Models;
using System.Numerics;

namespace LinqRecap;

public class Program
{
    static void Main(string[] args)
    {
        List<Person> personList = new List<Person>
        {
            new Person { FirstName = "Alice", LastName = "Smith", Age = 25, Country = "USA", Hobbies = new List<string> { "Reading", "Hiking" } },
            new Person { FirstName = "Bob", LastName = "Johnson", Age = 30, Country = "Canada", Hobbies = new List<string> { "Cooking", "Painting" } },
            new Person { FirstName = "Charlie", LastName = "Brown", Age = 22, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
            new Person { FirstName = "David", LastName = "Wilson", Age = 27, Country = "USA", Hobbies = new List<string> { "Photography", "Gardening" } },
            new Person { FirstName = "Emily", LastName = "Davis", Age = 28, Country = "Canada", Hobbies = new List<string> { "Traveling", "Yoga" } },
            new Person { FirstName = "John", LastName = "Smith", Age = 35, Country = "USA", Hobbies = new List<string> { "Reading", "Cooking", "Hiking" } },
            new Person { FirstName = "Jane", LastName = "Doe", Age = 32, Country = "Canada", Hobbies = new List<string> { "Reading", "Gaming" } },
            new Person { FirstName = "Michael", LastName = "Brown", Age = 24, Country = "UK", Hobbies = new List<string> { "Swimming", "Hiking" } },
            new Person { FirstName = "Daniel", LastName = "Wilson", Age = 30, Country = "USA", Hobbies = new List<string> { "Gardening", "Singing" } },
            new Person { FirstName = "Emma", LastName = "Johnson", Age = 29, Country = "Canada", Hobbies = new List<string> { "Yoga", "Cooking" } },
            new Person { FirstName = "Olivia", LastName = "Smith", Age = 23, Country = "USA", Hobbies = new List<string> { "Reading", "Gardening" } },
            new Person { FirstName = "James", LastName = "Davis", Age = 26, Country = "Canada", Hobbies = new List<string> { "Traveling" } },
            new Person { FirstName = "Noah", LastName = "Brown", Age = 29, Country = "UK", Hobbies = new List<string> { "Swimming", "Gaming" } },
            new Person { FirstName = "Ella", LastName = "Wilson", Age = 28, Country = "USA", Hobbies = new List<string> { "Photography", "Cooking" } },
            new Person { FirstName = "Liam", LastName = "Davis", Age = 31, Country = "Canada", Hobbies = new List<string> { "Reading", "Yoga" } }
        };

        // Find the person with name Michael and last name Brown

        Person michaelBrown = personList
           .Where(p => p.FirstName == "Michael") // && p.LastName == "Brown"
           .Where(p => p.LastName == "Brown")
           .FirstOrDefault();

        Person michaelBrown2 = personList
            .FirstOrDefault(p => p.FirstName == "Michael" && p.LastName == "Brown");

        Console.WriteLine($"{michaelBrown.FirstName} {michaelBrown.LastName} {michaelBrown.Age}");

        // Find all person with age between 20 and 27, sort them descending

        List<Person> ageBetween20and27 = personList
            .Where(p => p.Age >= 20 && p.Age <= 27)
            .OrderByDescending(p => p.Age)
            .ToList();

        Console.WriteLine("People with age 20 - 27: ");

        foreach (Person person in ageBetween20and27)
            Console.WriteLine($"{person.FirstName} {person.LastName} - {person.Age}");

        Console.WriteLine("------");

        // Find the oldest person

        Person oldestPerson = personList
            .OrderByDescending(p => p.Age)
            .FirstOrDefault();

        Person oldestPerson2 = personList
            .OrderBy(p => p.Age)
            .LastOrDefault();

        Console.WriteLine($"The oldest person is {oldestPerson.FirstName} {oldestPerson.LastName} - {oldestPerson.Age}");
        Console.WriteLine($"The oldest person is {oldestPerson2.FirstName} {oldestPerson2.LastName} - {oldestPerson2.Age}");

        // Find all first names from people from USA, and sort them by age decending

        List<string> firstNamesFromUSA = personList
            .Where(p => p.Country == "USA")
            .OrderByDescending(p => p.Age)
            .Select(p => p.FirstName)
            .ToList();

        Console.WriteLine("People from USA: ");
        foreach (string item in firstNamesFromUSA)
            Console.WriteLine(item);

        Console.WriteLine("----------");

        // find average age from all people

        double averageAge = personList
            .Average(p => p.Age);

        int minAge = personList
            .Min(p => p.Age);

        int maxAge = personList
            .Max(p => p.Age);

        int count = personList
            .Count();

        Console.WriteLine($"Count of items: {count}, average age is {averageAge}, " +
            $"the youngest {minAge} and the oldest age is {maxAge}");

        // Find 5 oldest ones from the list
        List<Person> fiveOldestOnes = personList
            .OrderByDescending(p => p.Age)
            .ThenByDescending(p => p.LastName)
            .Take(5)
            .ToList();

        Console.WriteLine("Top 5 oldest ones:");

        foreach (Person person in fiveOldestOnes)
            Console.WriteLine($"{person.FirstName} {person.LastName} - {person.Age}");

        Console.WriteLine("----------");

        // Find person with longest first name
        Person longestFirstName = personList
            .OrderByDescending(p => p.FirstName.Length)
            .FirstOrDefault();

        Console.WriteLine($"Person with longest first name is {longestFirstName.FirstName}");

        // Find all persons with hobby Yoga
        List<Person> peopleWithYogaHobby = personList
            .Where(p => p.Hobbies.Contains("Yoga"))
            .ToList();

        Console.WriteLine("Pople who like Yoga:");

        foreach (Person person in peopleWithYogaHobby)
            Console.WriteLine(person.FirstName + " " + person.LastName);

        Console.WriteLine("--------");

        // Print only first and last name from all the people

        List<string> fullNames = personList
            .Select(p => p.FirstName + " " + p.LastName)
            .ToList();

        Console.WriteLine("People full names: ");
        foreach (string fullName in fullNames)
            Console.WriteLine(fullName);

        Console.WriteLine("--------");

        bool personFromBiH = personList
            .Any(p => p.Country == "Bosnia and Herzegovina");

        bool olderThen40 = personList
            .Any(p => p.Age > 40);

        bool personWhoLikesYoga = personList
            .Any(p => p.Hobbies.Contains("Yoga"));

        List<string> countries = personList
            .DistinctBy(p => p.Country)
            .Select(p => p.Country)
            .ToList();

        // Exercise time:

        // Find all persons from the USA
        List<Person> personsFromUSA = personList
            .Where(person => person.Country == "USA")
            .ToList();

        // Find the oldest person in the list
        Person oldestPersonHere = personList
            .OrderByDescending(person => person.Age)
            .FirstOrDefault();

        // Calculate the average age of all persons
        double averagePeopleAge = personList
            .Average(person => person.Age);

        // Find all persons whose first name starts with the letter "J"
        List<Person> personsWithJ = personList
            .Where(person => person.FirstName.StartsWith("J"))
            .ToList();

        // Find the three youngest persons in the list
        List<Person> threeYoungestPersons = personList
            .OrderBy(person => person.Age)
            .Take(3)
            .ToList();

        // Check if any person has "Reading" as a hobby
        bool hasReadingHobby = personList
            .Any(person => person.Hobbies.Contains("Reading"));

        // Find all unique countries represented in the list
        List<string> uniqueCountries = personList
            .Select(person => person.Country)
            .Distinct()
            .ToList();

        // Sort the persons by their age in ascending order
        List<Person> personsSortedByAge = personList
            .OrderBy(person => person.Age)
            .ToList();

        // Find all persons who are exactly 30 years old
        List<Person> personsAge30 = personList
            .Where(person => person.Age == 30)
            .ToList();

        // Find the names of persons from the UK
        List<string> namesFromUK = personList
            .Where(person => person.Country == "UK")
            .Select(person => $"{person.FirstName} {person.LastName}")
            .ToList();

        // Check if all persons have at least one hobby
        bool allHaveHobbies = personList
            .All(person => person.Hobbies.Any());

        // Find all persons with both "Singing" and "Dancing" as hobbies
        List<Person> personsWithSingingAndDancing = personList
            .Where(person => person.Hobbies.Contains("Singing") && person.Hobbies.Contains("Dancing"))
            .ToList();

        // Find the persons with the longest first name and last name
        Person personWithLongestFirstName = personList
            .OrderByDescending(person => person.FirstName.Length)
            .FirstOrDefault();

        Person personWithLongestLastName = personList
            .OrderByDescending(person => person.LastName.Length)
            .FirstOrDefault();

        // Select the full names (FirstName + LastName) of all persons
        List<string> fullNamesX = personList
            .Select(person => $"{person.FirstName} {person.LastName}")
            .ToList();

    }
}