using Exercise104.Utils;
namespace Exercise104;

public class Program
{
    public static void Main()
    {
        // Step 2: Prompt the user to enter a sentence
        Console.WriteLine("Please enter a sentence:");
        string userInput = Console.ReadLine();

        // Use the extension method to reverse the words in the sentence
        string reversedSentence = userInput.ReverseWords();

        // Step 3: Display the original and the modified sentences
        Console.WriteLine("\nOriginal sentence:");
        Console.WriteLine(userInput);

        Console.WriteLine("\nReversed words sentence:");
        Console.WriteLine(reversedSentence);
    }
}