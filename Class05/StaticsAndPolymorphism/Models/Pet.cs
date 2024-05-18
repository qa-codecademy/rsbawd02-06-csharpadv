namespace StaticsAndPolymorphism.Models
{
    public class Pet
    {
        public string Name { get; set; }

        public virtual void Eat() 
        {
            Console.WriteLine("The pet is eating");
        }
    }
}
