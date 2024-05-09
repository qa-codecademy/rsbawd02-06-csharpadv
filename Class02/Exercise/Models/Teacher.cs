using Exercise.Interface;

namespace Exercise.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {UserName} - {Password} and I am teacher at {Subject} subject");
        }
    }
}
