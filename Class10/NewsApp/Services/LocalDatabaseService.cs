using NewsApp.Interfaces;
using NewsApp.Models;

namespace NewsApp.Services
{
    public class LocalDatabaseService : INewsService
    {
        public List<NewsArticle> GetAllNews()
        {
            return new List<NewsArticle>
            {
                new NewsArticle { Title = "LOCAL DATABASE NEWS 1", Body = "LOCAL DATABASE BODY 1"},
                new NewsArticle { Title = "LOCAL DATABASE NEWS 2", Body = "LOCAL DATABASE BODY 2"}
            };
        }

        public NewsArticle GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
