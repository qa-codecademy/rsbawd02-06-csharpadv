using NewsApp.Models;

namespace NewsApp.Interfaces
{
    public interface INewsService
    {
        public List<NewsArticle> GetAllNews();
        public NewsArticle GetById(int id);
    }
}
