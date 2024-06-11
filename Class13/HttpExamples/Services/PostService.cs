using HttpExamples.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;

namespace HttpExamples.Services
{
    public class PostService
    {
        private HttpClient _httpClient;

        public PostService()
        {
            _httpClient = new HttpClient();
        }

        public async Task GetPosts()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseJson = await response.Content.ReadAsStringAsync();

                List<Post> allPosts = JsonConvert.DeserializeObject<List<Post>>(responseJson);

                foreach (Post post in allPosts)
                {
                    Console.WriteLine($"{post.Id} - {post.Userid}");
                    Console.WriteLine(post.Title);
                    Console.WriteLine(post.Body);
                    Console.WriteLine("...................................................");
                }
            }
        }

    }
}
