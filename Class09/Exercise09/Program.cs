namespace Exercise09;

public class Program
{
    static void Main(string[] args)
    {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Exercise");
        string filePath = Path.Combine(folderPath, "calculations.txt");

        // Ensure the directory and file exist
        if (Directory.Exists(folderPath) == false)
            Directory.CreateDirectory(folderPath);

        if (File.Exists(filePath) == false)
            File.Create(filePath).Close();

        for (int i = 0; i < 3; i++)
        {
            // Get user input
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Calculate and get result string
            string result = Calculate(num1, num2);

            // Print result to console
            Console.WriteLine(result);

            // Append result to file with timestamp
            AppendResultToFile(filePath, result);
        }
    }

    static string Calculate(int num1, int num2)
    {
        int sum = num1 + num2;
        return $"{num1} + {num2} = {sum}";
    }

    static void AppendResultToFile(string filePath, string result)
    {
        string timeStampedResult = $"{DateTime.Now}: {result}";

        StreamWriter streamWriter = new StreamWriter(filePath, true);

        using (streamWriter)
        {
            streamWriter.WriteLine(timeStampedResult);
        }
    }
}