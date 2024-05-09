using Abstractions.Interfaces;
using Abstractions.Models;

namespace Abstractions;

class Program
{
    static void Main(string[] args)
    {
        Developer developer = new Developer("Developer One", 30);
        developer.CurrentRole = Enums.Role.Medior;
        developer.ProgrammingLanguages = new List<string> { "C#", "JavaScript" };

        Tester tester = new Tester("Tester One", 35, true);
        tester.NumberOfBugsFound = 20;

        Console.WriteLine(developer.GetInfo());
        Console.WriteLine(tester.GetInfo());

        Console.WriteLine(" OVO JE ISPIS U FOR PETLJI >>>>>>> ");

        List<Human> humansList = new List<Human>();
        humansList.Add(developer);
        humansList.Add(tester);

        foreach (Human human in humansList)
            Console.WriteLine(human.GetInfo());

        BackendDeveloper backendDeveloper = new BackendDeveloper("AV", 30);
        BackendDeveloper backendDeveloper2 = new BackendDeveloper("AV", 30);
        BackendDeveloper backendDeveloper3 = new BackendDeveloper("AV", 30);
        BackendDeveloper backendDeveloper4 = new BackendDeveloper("AV", 30);
        BackendDeveloper backendDeveloper5 = new BackendDeveloper("AV", 30);
        BackendDeveloper backendDeveloper6 = new BackendDeveloper("AV", 30);

        FrontendDeveloper frontendDeveloper1 = new FrontendDeveloper("AP", 28);
        FrontendDeveloper frontendDeveloper2 = new FrontendDeveloper("MP", 25);
        FrontendDeveloper frontendDeveloper3 = new FrontendDeveloper("TE", 20);

        Console.WriteLine("------ interfaces: ");

        PrintCodeInfo(backendDeveloper);
        PrintCodeInfo(frontendDeveloper1);
        PrintCodeInfo(frontendDeveloper2);
        PrintCodeInfo(frontendDeveloper3);
        PrintCodeInfo(tester);
    }

    static void PrintCodeInfo(IDeveloper developer)
    {
        developer.Code();
    }
}