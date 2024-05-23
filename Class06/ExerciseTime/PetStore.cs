using ExerciseTime.Models;

namespace ExerciseTime
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets = new List<T>();

        public void PrintPets()
        {
            foreach (T pet in Pets)
                Console.WriteLine(pet.PrintInfo());
        }

        public void BuyPet(string name)
        {
            T pet = Pets
                .Where(x => x.Name == name)
                .FirstOrDefault();
           
            if (pet == null)
            {
                Console.WriteLine("There is no pet by that name!");
                return;
            }
            
            Pets.Remove(pet);
            
            Console.WriteLine($"Congrats! You bought a pet named {pet.Name}");
        }
    }
}
