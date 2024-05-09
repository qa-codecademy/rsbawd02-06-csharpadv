using Exercise.Interface;

namespace Exercise.Models
{
    public class Student : User, IStudent
    {
        public Student(string name, string username, string password)
        {
            Name = name;
            UserName = username;
            Password = password;

            Grades = new List<string>();
        }

        public List<string> Grades { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {UserName} - {Password}");

            foreach(string grade in Grades )
                Console.WriteLine(grade);
        }
    }
}
