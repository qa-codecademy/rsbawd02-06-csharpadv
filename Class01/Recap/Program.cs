using Recap.Models;

namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise 1: Simple if/switch/loop exercise
            
            Write a C# program that takes an integer input from the user and 
            performs the following actions:
            
            If the input is less than 0, display "Negative number."
            If the input is greater than 0, display "Positive number."
            If the input is equal to 0, display "Zero."*/

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Negative number.");
            }
            else if (number > 0)
            {
                Console.WriteLine("Positive number.");
            }
            else
            {
                Console.WriteLine("Zero.");
            }

            /*
            Exercise 2: Simple console exercise
            
            Write a C# program that asks the user to enter their name and age. 
            The program should then display a message with their name and age 
            in the following format:
            
            Hello [Name], you are [Age] years old. */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            /*
            Exercise 3: Complex exercise
            
            Write a C# program that calculates the sum of all the even numbers 
            between 1 and a given number (inclusive) using a loop. Bonus: for odd numbers also.
            
            Example output:
            
            Enter a number: 10
            The sum of all even numbers between 1 and 10 is 30. */

            Console.Write("Enter a number: ");
            int numberX = int.Parse(Console.ReadLine());

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            for (int i = 1; i <= numberX; i++)
            {
                if (i % 2 == 0)
                    sumOfEvenNumbers += i;
                else
                    sumOfOddNumbers += i;
            }

            Console.WriteLine("The sum of all even numbers between 1 and " + numberX + " is " + sumOfEvenNumbers + ".");
            Console.WriteLine("The sum of all odd numbers between 1 and " + numberX + " is " + sumOfOddNumbers + ".");

            Console.WriteLine("..........................................");

            bool continueLoop = true;

            do
            {
                Console.WriteLine("Enter a number: ");

                string userNumberInput = Console.ReadLine();
                float numberInput = 0;

                bool parseResult = float.TryParse(userNumberInput, out numberInput);

                if (parseResult == false)
                {
                    Console.WriteLine("The input was not a number");
                    continue;
                }

                NumberStats(numberInput);

                Console.WriteLine("Do you want to exit? Type X, otherwise continue...");
                string userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "x")
                    continueLoop = false;

            } while (continueLoop);

            // Create a list of Person objects and populate it
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25, Gender = "Female" },
                new Person { Name = "Bob", Age = 40, Gender = "Male" },
                new Person { Name = "Charlie", Age = 35, Gender = "Male" },
                new Person { Name = "Diana", Age = 50, Gender = "Female" },
                new Person { Name = "Eve", Age = 28, Gender = "Female" }
            };

            // Use LINQ to filter the list and select only the Person objects who are older than 30 years
            List<Person> filteredPeople = people
                .Where(p => p.Age > 30)
                .ToList();

            // Order the filtered list by age in descending order
            List<Person> sortedPeople = filteredPeople
                .OrderByDescending(p => p.Age)
                .ToList();

            // Display the name and age of each Person in the console
            Console.WriteLine("People older than 30, sorted by age in descending order:");
            foreach (var person in sortedPeople)
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        static void NumberStats(float number)
        {
            Console.WriteLine($"Stats for number: {number}");

            if (number > 0)
                Console.WriteLine("- Positive");
            else if (number < 0)
                Console.WriteLine("- Negative");
            else
                Console.WriteLine("- Number is zero");

            if (number % 1 == 0)
                Console.WriteLine(" - Integer");
            else
                Console.WriteLine(" - Decimal");

            if (number % 2 == 0)
                Console.WriteLine(" - Even");
            else
                Console.WriteLine(" - Odd");
        }
    }
}
