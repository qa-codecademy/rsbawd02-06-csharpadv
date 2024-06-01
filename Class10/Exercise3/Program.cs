namespace Exercise103;

public class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask for user input
        Console.WriteLine("Please enter some text:");
        string userInput = Console.ReadLine();

        // Step 2: Write user input to a file
        string filePath = "userInput.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(userInput);
        }

        // Inform the user that the input has been saved
        Console.WriteLine("\nYour input has been saved to 'userInput.txt'.");

        // Step 3: Read the file content
        string fileContent;

        using (StreamReader reader = new StreamReader(filePath))
        {
            fileContent = reader.ReadToEnd();
        }

        // Step 4: Display the file content
        Console.WriteLine("\nThe content of 'userInput.txt' is:");
        Console.WriteLine(fileContent);
    }
}