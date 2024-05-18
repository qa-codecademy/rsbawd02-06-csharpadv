using GettersAndSetters.Models;

namespace GettersAndSetters;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();

        person1.FirstName = "Test F";

        person1.LastName = "Test L";

        Console.WriteLine(person1.FirstName);
        Console.WriteLine(person1.LastName);
    }
}