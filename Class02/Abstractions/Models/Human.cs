namespace Abstractions.Models
{
    public abstract class Human
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Human(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public abstract string GetInfo();
        // public abstract string GetDescription();
    }
}
