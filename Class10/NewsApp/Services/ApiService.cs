using NewsApp.Interfaces;
using NewsApp.Models;

namespace NewsApp.Services
{
    public class ApiService : INewsService
    {
        public List<NewsArticle> GetAllNews()
        {
            // Consume the HTTP REST API

            return new List<NewsArticle>()
            {
                new NewsArticle()
                {
                    Title = "News 1",
                    Body = "Body 1 ........"
                },

                new NewsArticle()
                {
                    Title = "News 2",
                    Body = "Body 2....."
                },

                new NewsArticle()
                {
                    Title = "News 3",
                    Body = "Body 3....."
                }
            };
        }

        public NewsArticle GetById(int id)
        {
            return new NewsArticle() { Title = "News 1", Body = "Body 1....."};
        }
    }
}
