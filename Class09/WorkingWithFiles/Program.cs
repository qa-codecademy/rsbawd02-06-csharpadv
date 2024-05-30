namespace WorkingWithFiles;

public class Program
{
    static void Main(string[] args)
    {
        string absoultePath = "C:\\Users\\almir.vuk\\source\\repos\\sedc-codecademy\\rsbawd02-06-csharpadv\\Class09\\WorkingWithFiles\\file.txt";

        string currentDirectory = Directory.GetCurrentDirectory();

        Console.WriteLine("Aplikacije se izvrsava u folderu: ");
        Console.WriteLine(currentDirectory);

        string newFolderPath = Directory.GetCurrentDirectory() + "\\NoviFolder";
        
        if (Directory.Exists(newFolderPath) == false)
        {
            // If directory does not exists create new one
            DirectoryInfo directoryInfo = Directory.CreateDirectory(newFolderPath);
        }

        // path to the new file
        string newFilePath = newFolderPath + "\\test.txt";

        if (File.Exists(newFilePath) == false)
        {
            // creating new file in C#
            FileStream newFile = File.Create(newFilePath);
            newFile.Close();
        }

        // Delete file if exists
        //if (File.Exists(newFilePath))
        //    File.Delete(newFilePath);

        if (File.Exists(newFilePath))
        {
            // this methods reads all the text from the file and saves it to variable
            string fileContent = File.ReadAllText(newFilePath);

            Console.WriteLine($"File content is: ");
            Console.WriteLine(fileContent);

            Console.WriteLine("Type additional content for this txt:");
            string userInputContent = Console.ReadLine();

            // Append all text to the existing file
            File.AppendAllText(newFilePath, "\n" + userInputContent);

            // .......  Copy from one file to another

            // new files
            string goranTxt = newFolderPath + "\\noviTextFileZaGorana.txt";
            string goranTxtCopy = newFolderPath + "\\noviTextFileZaGoranaCopy.txt";

            // manual copy
            if(File.Exists(goranTxt) == false)
                File.AppendAllText(goranTxt, fileContent + "... this is edited content");

            // Copy using .NET method
            if (File.Exists(goranTxtCopy) == false)
                File.Copy(newFilePath, goranTxtCopy);
        }

        // Working with streams

        Console.WriteLine("Working with streams.... ");

        string streamFilesFolder = Directory.GetCurrentDirectory() + "\\streams";
        string longTextFile = streamFilesFolder + "\\longText.txt";

        if (Directory.Exists(streamFilesFolder) == false)
        {
            Directory.CreateDirectory(streamFilesFolder);
            Console.WriteLine("The folder created");
        }

        if (File.Exists(longTextFile) == false)
            File.Create(longTextFile).Close();

        StreamWriter streamWriter = new StreamWriter(longTextFile);

        using (streamWriter)
        {
            streamWriter.WriteLine("1. Milica");
            streamWriter.WriteLine("2. Goran");
            streamWriter.WriteLine("3. Dordje");
            streamWriter.WriteLine("4. Sava");
            streamWriter.WriteLine("5. Almir");
        }

        StreamWriter streamWriterAppend = new StreamWriter(longTextFile, true);

        using (streamWriterAppend)
        {
            streamWriterAppend.WriteLine("6. Tamara");
            streamWriterAppend.WriteLine("7. Zarko");
        }

        Console.WriteLine(".............. READING THE STREAM - START ......");

        StreamReader streamReader = new StreamReader(longTextFile);

        using (streamReader)
        {
            string firstLine = streamReader.ReadLine();
            string secondLine = streamReader.ReadLine();
            string thirdLine = streamReader.ReadLine();

            string restOfTheContent = streamReader.ReadToEnd();

            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(restOfTheContent);
        }

        Console.WriteLine(".............. READING THE STREAM - END ......");

        Console.WriteLine("......   Done ........");
    }
}