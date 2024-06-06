using Newtonsoft.Json;
using System.Drawing;
namespace Exerise;

class Program
{
    static void Main()
    {
        string dogsFilePath = Directory.GetCurrentDirectory() + "\\dogs.txt";

        // Get user inputs
        Console.Write("Enter Dog's Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Dog's Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Dog's Color: ");
        string color = Console.ReadLine();

        // Create a Dog object
        Dog newDog = new Dog();
        newDog.Name = name;
        newDog.Age = age;
        newDog.Color = color;

        // Serialize the Dog object to JSON and write it to a file
        string json = JsonConvert.SerializeObject(newDog);

        if (File.Exists(dogsFilePath) == false)
            File.Create(dogsFilePath).Close();

        File.AppendAllText(dogsFilePath, json + Environment.NewLine);

        // Read and print all dogs from the file
        ReadAndPrintAllDogs(dogsFilePath);
    }

    static void ReadAndPrintAllDogs(string filePath)
    {
        if (File.Exists(filePath) == false)
            Console.WriteLine("No dogs found in the file.");
         
        string[] jsonDogs = File.ReadAllLines(filePath);
            
        List<Dog> dogs = new List<Dog>();

        foreach (string json in jsonDogs)
        {
            Dog dog = JsonConvert.DeserializeObject<Dog>(json);
            dogs.Add(dog);
        }

        Console.WriteLine("All Dogs in the file:");
     
        foreach (Dog dog in dogs)
            Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
    }
}
