using HttpExamples.Services;

namespace HttpExamples;

public class Program
{
    public static void Main()
    {
        PostService postService = new PostService();

        Console.WriteLine("Before getting posts");

        Task getAllPosts = postService.GetPosts();

        getAllPosts.Wait();

        Console.WriteLine("All posts are loaded as string");
    }
}