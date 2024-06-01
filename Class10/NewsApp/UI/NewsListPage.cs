using NewsApp.Interfaces;
using NewsApp.Models;

namespace NewsApp.UI
{
    public class ListPageUI
    {
        public List<NewsArticle> newsList = new List<NewsArticle>();
       
        private INewsService _newsService;

        public ListPageUI(INewsService service)
        {
            _newsService = service;
        }

        public void ShowTheNewsUI()
        {
            newsList = _newsService.GetAllNews();

            Console.WriteLine("Todays news");

            foreach (NewsArticle item in newsList)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Body);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
