using NewsApp.Mock;
using NewsApp.Services;
using NewsApp.UI;

namespace NewsApp;

public class Program
{
    static bool userHasInternet = true;
    public static void Main()
    {
        //// Use this to test
        MockService mockService = new MockService();

        // Use this for real data
        ApiService backendService = new ApiService();
        
        ListPageUI articlePage = null;

        if (userHasInternet)
        {
            articlePage = new ListPageUI(mockService);
        }
        else
        {
            LocalDatabaseService localDatabaseService = new LocalDatabaseService();
            
            articlePage = new ListPageUI(localDatabaseService);
        }

        articlePage.ShowTheNewsUI();
    }
}