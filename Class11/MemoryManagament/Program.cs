using MemoryManagament.Utils;

namespace MemoryManagament;

public class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 20;

        a = b;
        b = 30;

        Console.WriteLine(a);
        Console.WriteLine(b);

        bool isEnabled = false;
        char letter = 'a';

        string sentence = "some value";

        Student student = new Student();

        student.FirstName = "Zoran";
        student.LastName = "Malinovic";

        // int broj = 10;
        // var broj = 10;

        // Student student2 = new Student
        var student2 = new Student();

        student2.FirstName = "Miroslav";

        student2 = student;

        student2.FirstName = "Almir";

        Console.WriteLine(student.FirstName);
        Console.WriteLine(student2.FirstName);

        Student studentX = new Student();

        Console.WriteLine(studentX.FirstName);

        Console.WriteLine(".................................");

        string path = "noviFajl.txt";

        if (File.Exists(path) == false)
            File.Create(path)
                .Close();

        OurTextWriter ourTextWriter = new OurTextWriter(path);

        using (ourTextWriter)
        {
            ourTextWriter.WriteContent("We are learning C# we are happy!");
        } // ourTextWriter.Dispose()   

        ourTextWriter.WriteContent("Almir");
    }
}