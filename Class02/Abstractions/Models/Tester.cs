using Abstractions.Interfaces;

namespace Abstractions.Models
{
    public class Tester : Human, IDeveloper
    {
        public bool IsQACertified { get; set; }
        public int NumberOfBugsFound { get; set; }

        public Tester(string fullName, int age, bool isQACertified) 
            : base (fullName, age)
        {
            IsQACertified = isQACertified;
        }

        public override string GetInfo()
        {
            return $"{FullName} - {Age} - IsQACertified: {IsQACertified} - Number of Bugs Found: {NumberOfBugsFound}";
        }

        public void Code()
        {
            Console.WriteLine("I am tester, but sometimes I do coding as well");
        }

        public void Debug()
        {
            Console.WriteLine("I am tester, but I sometimes do debugging of the code");
        }
    }
}
