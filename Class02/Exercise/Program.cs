using Exercise.Interface;
using Exercise.Models;

namespace Exercise;

class Program
{
    static void Main(string[] args)
    { 
        Teacher teacher1 = new Teacher();
        teacher1.Name = "Teacher 1";
        teacher1.UserName = "tusername1";
        teacher1.Password = "tpassword1";
        teacher1.Subject = "Math";

        Teacher teacher2 = new Teacher();
        teacher2.Name = "Teacher 2";
        teacher2.UserName = "tusername2";
        teacher2.Password = "tpassword2";
        teacher2.Subject = "Programming";

        Student student1 = new Student("Student1", "studentusername", "studentPassword");
        student1.Grades.Add("Deset");
        student1.Grades.Add("Osam");
        student1.Grades.Add("Devet");

        Student student2 = new Student("Student2", "222studentusername", "222studentPassword");
        student2.Grades.Add("Deset");
        student2.Grades.Add("Deset");
        student2.Grades.Add("Devet");

        PrintThemAll(student1);
        PrintThemAll(student2);

        PrintThemAll(teacher1);
        PrintThemAll(teacher2);
    }

    private static void PrintThemAll(IUser user)
    {
        user.PrintUser();
    }
}