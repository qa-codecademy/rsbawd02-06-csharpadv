namespace StaticsAndPolymorphism.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public override void Eat()
        {
            //base.Eat();

            Console.WriteLine("I am DOG and now I am eating");
        }
    }
}
