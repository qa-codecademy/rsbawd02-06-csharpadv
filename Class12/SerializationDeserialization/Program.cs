using Newtonsoft.Json;
using SerializationDeserialization.Entities;
using System.Globalization;

namespace SerializationDeserialization;

public class Program
{
    public static void Main()
    {
        string myFirstJsonPath = "C:\\Users\\almir.vuk\\source\\repos\\sedc-codecademy\\rsbawd02-06-csharpadv\\Class12\\SerializationDeserialization\\OurData\\myFirstJson.json";
        string moviesPath = "C:\\Users\\almir.vuk\\source\\repos\\sedc-codecademy\\rsbawd02-06-csharpadv\\Class12\\SerializationDeserialization\\OurData\\movies.json";
        
        StreamReader streamReader = new StreamReader(myFirstJsonPath);
        StreamReader streamReaderMovies = new StreamReader(moviesPath);

        string jsonContent = string.Empty;
        string jsonContentMovies = string.Empty;

        using (streamReader)
        {
            jsonContent = streamReader.ReadToEnd();
        }

        using (streamReaderMovies)
        {
            jsonContentMovies = streamReaderMovies.ReadToEnd();
        }

        Student bob = JsonConvert.DeserializeObject<Student>(jsonContent);

        Console.WriteLine(".... THIS IS C# OBJECT");
        Console.WriteLine($"{bob.FirstName} {bob.LastName}");
        Console.WriteLine(bob.Age);

        Student zoka = new Student();
        zoka.FirstName = "Zoran";
        zoka.LastName = "Malinovic";
        zoka.Age = 35;
        zoka.IsPartTime = false;

        string zokaAsJson = JsonConvert.SerializeObject(zoka);

        Console.WriteLine("Zoka as json file: ");
        Console.WriteLine(zokaAsJson);

        Console.WriteLine("-------------------- Movies -----------------------");

        List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(jsonContentMovies);

        foreach (Movie item in movies)
        {
            Console.WriteLine("..................");
            Console.WriteLine($"{item.Title} - {item.Year} - {item.Genre} - IMDB Rating: {item.imdbRating}");
        }

        List<Movie> ratingOver8 = movies
            .Where(m => m.imdbRating > 8)
            .ToList();

        Console.WriteLine("++++++++++++++++++++++ Movies rated ove 8.0");

        foreach (Movie item in ratingOver8)
        {
            Console.WriteLine("..................");
            Console.WriteLine($"{item.Title} - {item.Year} - {item.Genre} - IMDB Rating: {item.imdbRating}");
        }
    }
}