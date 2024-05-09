namespace Exercise.Interface
{
    public interface IUser
    {
        public int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }

        void PrintUser();
    }
}
