namespace Generics.Utils
{
    public class ListHelper<T>
    {
        public void GoThroughList(List<T> listOfItems) 
        {
            foreach (T item in listOfItems)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfo(List<T> listOfItems)
        {
            Console.WriteLine($"This list has {listOfItems.Count}, and members are type of " +
                $"{listOfItems.GetType().FullName}");
        }
    }
}
