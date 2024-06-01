using NewsApp.Interfaces;
using NewsApp.Models;

namespace NewsApp.Mock
{
    public class MockService : INewsService
    {
        public List<NewsArticle> GetAllNews()
        {
            return new List<NewsArticle> 
            { 
                new NewsArticle { Title = "TEST 1", Body = "TEST BODY 1"},
                new NewsArticle { Title = "TEST 2", Body = "TEST BODY 2"} 
            };
        }

        public NewsArticle GetById(int id)
        {
            return new NewsArticle { Title = "TEST 1", Body = "TEST BODY 1" };
        }
    }
}
