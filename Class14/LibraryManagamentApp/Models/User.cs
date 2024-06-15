public class User
{
    public string Name { get; set; }

    private string _email;
    public string Email 
    { 
        get 
        {
            return _email;
        } 

        set 
        { 
            if (string.IsNullOrEmpty(value)) 
            {
                throw new Exception();
            }

            _email = value;
        } 
    }

    public List<Book> CheckedOutBooks { get; set; } = new List<Book>();
}
